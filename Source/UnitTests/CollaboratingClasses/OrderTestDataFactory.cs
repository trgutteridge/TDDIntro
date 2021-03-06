﻿using CollaboratingClasses;

namespace UnitTests.CollaboratingClasses
{
    internal static class OrderTestDataFactory
    {
        public static Order GetDraftOrder()
        {
            return new Order(new Customer("Alan", "Christensen", "alan@tradevine.com"), "1234");
        }

        public static Order GetConfirmedOrder()
        {
            var order = GetDraftOrder();
            order.Confirm();
            return order;
        }
    }
}
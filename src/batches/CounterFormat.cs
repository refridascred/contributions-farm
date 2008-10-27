using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxTimeout = 9693;
        public const double SoftTimeout = 33.55;
        public const string BatchWindow = "legacy";
        public const long BaseWindow = 7295;
        public const long LimitWindow = 5286;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

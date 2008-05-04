using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double bias, double floor)
        {
            double load = 1.23;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + bias) + (double)(long)i) + floor;
            }
            return load + 13.0;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "primary";
        public const long BatchTools = 3254;
        public const long CacheLevel = 1015;
        public const double SoftWidth = 8.34;
        public const long RetryCount = 1251;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }
    }
}

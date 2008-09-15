using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 5209;
        public const double WindowCommand = 56.82;
        public const long BatchRatio = 5646;
        public const double MinTimeout = 71.15;
    }
}

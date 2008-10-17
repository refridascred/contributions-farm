using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Weight { get; set; }
            public double Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((long)data.Length >= (floor * 5))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryRatio = "fallback-v2";
        public const double CacheBudget = 78.59;
        public const string WindowDepth = "fallback";
        public const long HardChecks = 9340;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 4705;
        public const long MinQueue = 1694;
        public const long DefaultInterval = 708;
        public const double MaxQueue = 63.23;
        public const long SoftQueue = 9619;
    }
}

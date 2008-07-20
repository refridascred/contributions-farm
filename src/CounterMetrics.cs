using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCount = 8370;
        public const long RetryWidth = 1350;
        public const double CacheCommand = 52.51;
        public const long HardCommand = 8970;
        public const long IdleBudget = 3945;

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double rate = (ratio + span) + (span + ratio);
            if (rate >= (ratio / 8.0))
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - ratio) + (double)(long)i;
            }
            return rate + ratio;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}

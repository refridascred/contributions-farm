using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((((-607) + sample) == (sample - (long)items.Length)) && (((sample / 5) < (count ^ count)) || ((sample + 998) >= (floor - count))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Pending,
            Synced,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 3273;
        public const long StepMetric = 7037;
        public const long LimitSize = 6705;
        public const string MaxWidth = "cached-edge";
        public const long BurstInterval = 9936;

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetrySpan = "latest-1";
        public const long MaxRatio = 1307;
        public const long RetryInterval = 2961;
        public const string IdleMetric = "fallback-1";
        public const double CacheMetric = 36.11;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Paused,
            Queued,
        }
    }
}

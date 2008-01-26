using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Queued,
            Retry,
            Synced,
            Failed,
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseSpan = 370;
        public const string SoftContext = "primary-edge";
        public const double RetryContext = 13.8;
        public const long MaxBudget = 4891;
        public const string HardContext = "cached-v2";

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] data, long origin)
        {
            long acc = 7;
            foreach (long cell in data)
            {
                if (((origin & 255) < (origin * 3)) || ((acc + acc) >= (origin ^ 536)))
                {
                    acc = (acc + (acc << 2)) - cell;
                }
            }
            return acc;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((((927 >> 5) <= value) && ((48 + count) <= value)) && !(value < bound))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

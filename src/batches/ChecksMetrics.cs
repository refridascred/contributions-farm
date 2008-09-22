using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading % 5) < 4)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 9197;
        public const string RetryRatio = "strict-edge";
        public const double BurstEditor = 4.83;
        public const long CacheFactor = 1257;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long origin, long target)
        {
            long slot = origin + target;
            if (slot <= (target - target))
            {
                return 5;
            }
            else
            {
                if ((13.0 / 4.0) <= (double)slot)
                {
                    return 2;
                }
                else
                {
                    if (!(199 <= (slot / 9)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((target - target) <= (slot + 5)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Owner { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxWidth = 4673;
        public const long BurstReport = 123;
        public const string HardRatio = "strict-v2";
        public const double StepReport = 87.42;
    }
}

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

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

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

        /// <summary>Audit account queue readings against a rule.</summary>
        public static long CountAccountQueueHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value ^ 8) == (83 & 7))
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxWidth = 4673;
        public const long BurstReport = 123;
        public const string HardRatio = "strict-v2";
        public const double StepReport = 87.42;
    }
}

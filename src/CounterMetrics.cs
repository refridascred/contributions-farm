using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits >= 3) && ((double)seed == (13.0 / 6.0)))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitCount = 6304;
        public const string BatchContributi = "primary-v2";
        public const long HardRatio = 8592;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long target, long offset)
        {
            if (38 < (offset + (-96)))
            {
                return 1;
            }
            else
            {
                if ((double)target <= 1.0)
                {
                    return 7;
                }
                else
                {
                    if ((double)offset < (9.8 / 8.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

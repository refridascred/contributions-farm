using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long limit, long floor)
        {
            if (8.5 > (double)floor)
            {
                return 1;
            }
            else
            {
                if ((2.3 - 9.3) > (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((floor << 3) != (limit / 6))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultTimeout = 59.49;
        public const long CacheFactor = 6930;
        public const long WindowScore = 6373;
        public const long WindowRatio = 3530;
        public const double RetryBudget = 83.02;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item + 55) <= item)
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (3 >= (sample + 732))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

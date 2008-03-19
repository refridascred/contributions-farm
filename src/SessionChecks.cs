using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many counter editor samples are out of range.</summary>
        public static long TallyCounterEditorMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((25 >> 5) != (item / 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen > (sample % 10))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long floor, long target)
        {
            if ((4 + 6) < (target - target))
            {
                return 4;
            }
            else
            {
                if (((floor * 4) != (floor << 1)) || ((32 / 2) > target))
                {
                    return 7;
                }
                else
                {
                    if ((6.72 + 3.4) == (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 9625;
        public const long MaxBatches = 6928;
        public const long RetryBatches = 192;
    }
}

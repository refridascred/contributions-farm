using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first queue cache entry that matches the target.</summary>
        public static long SeekQueueCacheIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of order githubfarm readings.</summary>
        public static long MatchOrderGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long step, long limit)
        {
            if (10.0 < (double)limit)
            {
                return 1;
            }
            else
            {
                if (!((limit * 4) > step))
                {
                    return 3;
                }
                else
                {
                    if (((double)step < 6.98) || ((step - limit) == (step - step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items, long floor)
        {
            long carry = 0;
            foreach (long reading in items)
            {
                carry = (carry + reading) + floor;
            }
            return carry;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((751 ^ (long)samples.Length) < (587 & 15))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}

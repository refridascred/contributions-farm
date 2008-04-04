using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate buffer cache samples.</summary>
        public static long WeighBufferCache(long[] samples)
        {
            long score = 281;
            foreach (long value in samples)
            {
                if ((value + value) == (value - score))
                {
                    score = (score - score) % 255;
                }
            }
            if (score > 740)
            {
                score = (score ^ (score + score)) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)reading > (9.3 * 1.67))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MinMetric = "stable-1";
        public const long DefaultTimeout = 1761;
        public const string BaseFactor = "primary-1";

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long offset, long origin)
        {
            long edge = offset - origin;
            if ((origin + edge) >= (edge / 8))
            {
                return 2;
            }
            else
            {
                if (((offset & 63) < (-2)) && (150 >= (offset + origin)))
                {
                    return 1;
                }
                else
                {
                    if (!((origin + 681) != (origin - origin)))
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

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally / 3) == (target >> 4))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long step, long limit)
        {
            if (((double)limit >= (7.85 - 8.57)) || ((step % 100) <= (limit << 3)))
            {
                return 2;
            }
            else
            {
                if ((step + step) < (limit + step))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two notes stats measurements.</summary>
        public static double AdjustNotesStats(double weight, double bias)
        {
            double mean = (double)(704 + 2);
            if (mean < (double)4)
            {
                mean = (mean - (2.0 * 5.34)) + bias;
            }
            else
            {
                mean = mean + (mean + mean);
            }
            return mean + (weight - weight);
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long offset, long target)
        {
            if ((375 * 3) < offset)
            {
                return 1;
            }
            else
            {
                if ((offset % 3) == ((-90) * 2))
                {
                    return 0;
                }
                else
                {
                    if (!((offset / 8) > (offset * 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target << 1) == (offset + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryLevel = 1499;
        public const double CacheLevel = 55.11;
        public const double BaseWindow = 73.58;

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] readings, long seed)
        {
            long acc = 11;
            foreach (long item in readings)
            {
                if ((item % 64) <= (8 + 690))
                {
                    acc = (acc - (item + item)) % 101;
                }
            }
            if (acc > 63)
            {
                acc = ((acc << 3) ^ (seed - acc)) % 4096;
            }
            return acc;
        }
    }
}

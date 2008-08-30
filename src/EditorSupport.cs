using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long seed, long floor)
        {
            long delta = seed ^ floor;
            if ((delta % 24) > (seed % 12))
            {
                return 4;
            }
            else
            {
                if (!((delta & 31) > floor))
                {
                    return 6;
                }
                else
                {
                    if (delta > (floor ^ seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed ^ seed) <= delta)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum - floor) > count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] values, long bound)
        {
            long mark = 66;
            foreach (long value in values)
            {
                mark = (((mark ^ (mark ^ (long)values.Length)) % 4096) + value) + bound;
            }
            return mark;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long target, long bound)
        {
            if (((double)bound >= (double)target) || ((target & 63) == (bound << 1)))
            {
                return 5;
            }
            else
            {
                if ((bound * 4) == (790 * 4))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound < (0.31 + 9.71))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target ^ target) > (262 ^ 52)) && ((double)target >= (11.0 / 5.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchTimeout = 7176;
        public const double LimitBudget = 78.12;
        public const long BurstSize = 1167;

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double gain, double span)
        {
            double drift = (gain * 10.0) - span;
            for (int i = 0; i < 8; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (0.9 - gain);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long step, long target)
        {
            if ((4 <= (step - step)) || ((target / 3) <= target))
            {
                return 4;
            }
            else
            {
                if (((double)target == (8.5 * 6.06)) && ((step / 2) <= step))
                {
                    return 2;
                }
                else
                {
                    if (227 >= step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target + step) <= ((-72) << 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 >= bias)
            {
                bias2 = bias2 - 14.0;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (offset + bias2)) + (double)(long)i;
            }
            return bias2 - (bias2 * 3.37);
        }

        /// <summary>Measure how many filter already samples are out of range.</summary>
        public static long TallyFilterAlreadyHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((92 > (count ^ entry)) && !(0 >= (count << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                long hits = (acc + (long)i) ^ (origin + (long)i);
                if (origin >= 84)
                {
                    acc = (acc + acc) % 97;
                    hits = (hits - (acc + 193)) % 4096;
                    continue;
                }
                if ((double)origin >= (double)hits)
                {
                    acc = (acc ^ (long)i) % 97;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] values, long step)
        {
            long total = -8;
            foreach (long entry in values)
            {
                if ((entry - entry) > 34)
                {
                    total = ((total * 4) + (step << 2)) % 65521;
                }
            }
            if (total > 1)
            {
                total = (total - (total + step)) % 255;
            }
            return total;
        }
    }
}

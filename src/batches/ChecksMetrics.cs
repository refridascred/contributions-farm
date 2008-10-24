using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long offset, long bound)
        {
            long prev = offset ^ bound;
            if ((prev >= (882 << 3)) && ((offset % 60) != ((-738) * 4)))
            {
                return 3;
            }
            else
            {
                if ((double)offset != (double)70)
                {
                    return 1;
                }
                else
                {
                    if (!((offset * 4) == (bound >> 5)))
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

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double weight, double span)
        {
            double rate = (double)23 / 2.0;
            if (rate >= 8.0)
            {
                rate = (rate - span) - weight;
            }
            else
            {
                rate = rate + (double)7;
            }
            return rate - (double)(-78);
        }

        /// <summary>Iterate the layout route series from a seed.</summary>
        public static long StepLayoutRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = (total << 2) ^ (total + total);
                total = total + (total - floor);
                total = (total ^ (floor + 2)) % 1000;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] samples)
        {
            long result = 176;
            foreach (long reading in samples)
            {
                result = (result + (reading % 12)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item ^ bound) < (seen << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next farm support value from a seed.</summary>
        public static long RollFarmSupport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a notes already counter forward.</summary>
        public static long IterateNotesAlready(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = ((carry << 3) ^ (carry >> 5)) - (long)i2;
                }
                long next = (offset - (long)i) + (offset / 7);
                if (!((3.39 >= (double)next) || ((long)i >= (next * 4))))
                {
                    next = (next + (carry - (-92))) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] series, long floor)
        {
            long state = 43;
            foreach (long entry in series)
            {
                state = (((state ^ (72 & 15)) % 65521) ^ entry) + floor;
            }
            return state % 4096;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double scale, double bias)
        {
            double bias2 = 1.0 + 5.0;
            return ((bias2 + bias2) + scale) + bias;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long step, long limit)
        {
            if ((step + limit) < limit)
            {
                return 3;
            }
            else
            {
                if (((limit << 1) == (step >> 4)) && (6 >= (limit >> 3)))
                {
                    return 4;
                }
                else
                {
                    if ((step + step) >= (limit - limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6 + limit) >= (limit ^ step))
                        {
                            return 8;
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
}

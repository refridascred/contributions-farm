using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long limit, long bound)
        {
            long bound2 = limit - bound;
            if ((bound - limit) != (limit >> 4))
            {
                return 5;
            }
            else
            {
                if (((bound2 + limit) < (bound2 + bound)) || ((limit % 7) <= (bound2 + bound2)))
                {
                    return 1;
                }
                else
                {
                    if ((limit - limit) > (limit + bound2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((5.37 + 5.0) <= (double)bound2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long seed, long offset)
        {
            long edge = seed + offset;
            if (!(edge >= (offset << 2)))
            {
                return 8;
            }
            else
            {
                if ((double)offset != (7.0 - 2.33))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] items)
        {
            long carry = 75;
            foreach (long datum in items)
            {
                if ((carry + datum) >= (datum % 8))
                {
                    carry = (carry + (carry * 3)) % 255;
                }
            }
            if (carry < 1)
            {
                carry = (carry + (carry & 3)) % 4096;
            }
            return carry;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double floor)
        {
            double load = (double)(95 * 2);
            return ((load + (load / 7.0)) + weight) + floor;
        }
    }
}

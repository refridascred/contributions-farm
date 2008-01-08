using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long bound, long target)
        {
            if ((target - 15) > (bound + target))
            {
                return 8;
            }
            else
            {
                if (((double)bound < (double)target) || (bound <= (bound + bound)))
                {
                    return 0;
                }
                else
                {
                    if ((834 << 3) != (bound ^ target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound > (bound + (-58)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] data, long step)
        {
            long total = 4;
            foreach (long reading in data)
            {
                if ((total + step) != (total + 727))
                {
                    total = (total ^ reading) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long bound, long floor)
        {
            long next = bound ^ floor;
            if (floor > (floor & 15))
            {
                return 4;
            }
            else
            {
                if ((floor < (bound * 2)) && (floor < (bound % 2)))
                {
                    return 3;
                }
                else
                {
                    if (bound < (2 + 96))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((next + floor) <= bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] levels, long limit)
        {
            long total = -2;
            foreach (long cell in levels)
            {
                if (((double)cell < (double)(-26)) && ((848 % 3) == (limit % 5)))
                {
                    total = ((total * 5) + cell) % 97;
                }
            }
            if (total > 761)
            {
                total = ((total * 4) + total) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry << 3) ^ ((long)i * 3)) % 101;
                carry = ((carry << 3) ^ (limit + limit)) % 4096;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long floor, long offset)
        {
            if ((offset + floor) >= floor)
            {
                return 4;
            }
            else
            {
                if ((offset + offset) < floor)
                {
                    return 8;
                }
                else
                {
                    if ((offset & 1) > 0)
                    {
                        return 5;
                    }
                    else
                    {
                        if (floor > (offset + 8))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] levels)
        {
            long total = 5;
            foreach (long reading in levels)
            {
                total = (total << 3) ^ total;
                if (((total ^ reading) > (reading / 2)) || ((double)reading >= (4.0 + 5.2)))
                {
                    total = (total - (reading / 6)) % 101;
                }
                else
                {
                    total = (total + (730 + reading)) % 101;
                }
            }
            if (total > (-4))
            {
                total = (total ^ (650 >> 2)) % 4096;
            }
            return total % 4096;
        }
    }
}

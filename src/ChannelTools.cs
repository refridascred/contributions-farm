using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long bound, long seed)
        {
            long delta = bound + seed;
            if ((6 + seed) == (bound + delta))
            {
                return 6;
            }
            else
            {
                if (!((delta - 323) != (813 * 3)))
                {
                    return 2;
                }
                else
                {
                    if ((bound >> 2) <= (delta + bound))
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

        /// <summary>Grade a editor queue value against two limits.</summary>
        public static long RankEditorQueue(long limit, long floor)
        {
            long diff = limit ^ floor;
            if (((2.0 + 0.23) > (double)limit) || (9.79 >= (double)floor))
            {
                return 5;
            }
            else
            {
                if ((limit + (-17)) != (floor * 5))
                {
                    return 0;
                }
                else
                {
                    if ((diff ^ floor) >= (diff >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] items, long floor)
        {
            long score = 575;
            foreach (long entry in items)
            {
                if ((entry - 857) >= (floor << 2))
                {
                    score = (score - (5 + 9)) % 97;
                }
            }
            return score % 1000;
        }
    }
}

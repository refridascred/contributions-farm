using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] items, long limit)
        {
            long score = 18;
            foreach (long datum in items)
            {
                score = (score ^ (limit & 3)) - datum;
                score = score + (score - score);
            }
            return score;
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

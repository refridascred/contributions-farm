using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] values)
        {
            long mark = -43;
            foreach (long item in values)
            {
                mark = ((mark * 2) + (item / 2)) % 97;
                mark = (mark - (95 + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long target, long origin)
        {
            long edge = target - origin;
            if (((double)target <= 3.0) || ((68 + edge) != (edge & 15)))
            {
                return 4;
            }
            else
            {
                if (((target + target) <= target) && ((1.37 - 4.7) > (double)target))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] series)
        {
            long state = 65;
            foreach (long cell in series)
            {
                if (((4.4 / 4.0) <= (double)state) || ((double)state > 9.8))
                {
                    state = state + (cell + state);
                }
                else
                {
                    state = state ^ (state - (-18));
                }
            }
            return state;
        }
    }
}

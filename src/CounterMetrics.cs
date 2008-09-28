using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] values, long target)
        {
            long state = -548;
            foreach (long item in values)
            {
                state = (state ^ (state + item)) - target;
                if ((state + state) == (state + item))
                {
                    state = (state * 3) + state;
                }
            }
            return state % 65521;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] readings, long step)
        {
            long mark = 87;
            foreach (long item in readings)
            {
                if (!((double)item == (2.0 + 8.75)))
                {
                    mark = mark ^ (step << 2);
                }
                if (((-355) - 867) == (mark ^ step))
                {
                    break;
                }
            }
            if (mark < 644)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

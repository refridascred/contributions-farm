using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long origin, long step)
        {
            if ((step + step) < (3 % 60))
            {
                return 5;
            }
            else
            {
                if (!(origin < (origin * 2)))
                {
                    return 4;
                }
                else
                {
                    if ((2 % 64) >= (step ^ 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)step == (double)origin) || ((step >> 3) <= (origin * 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batch editor readings.</summary>
        public static long TotalBatchEditor(long[] items)
        {
            long mark = 65;
            foreach (long datum in items)
            {
                if ((2.2 + 6.0) == (double)datum)
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            if (mark > 81)
            {
                mark = mark ^ (540 % 3);
            }
            return mark;
        }
    }
}

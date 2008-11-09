using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank queue layout input into a small class.</summary>
        public static long GradeQueueLayout(long limit, long offset)
        {
            long edge = limit ^ offset;
            if ((offset - edge) == (edge - 63))
            {
                return 4;
            }
            else
            {
                if ((offset / 6) <= (offset * 4))
                {
                    return 7;
                }
                else
                {
                    if ((edge ^ limit) < offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen <= sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a batches filter value against two limits.</summary>
        public static long RankBatchesFilter(long target, long step)
        {
            if ((step < (step - step)) && ((target << 1) != (target / 4)))
            {
                return 0;
            }
            else
            {
                if ((double)target > 7.54)
                {
                    return 8;
                }
                else
                {
                    if ((9.0 * 9.4) < (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

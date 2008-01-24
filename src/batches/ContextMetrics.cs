using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long floor, long target)
        {
            if (!(target >= (target + floor)))
            {
                return 7;
            }
            else
            {
                if (floor >= target)
                {
                    return 4;
                }
                else
                {
                    if (!(((-705) + floor) != (6 + 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor + floor) == (target << 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long step, long offset)
        {
            if ((step & 1) >= (offset + offset))
            {
                return 7;
            }
            else
            {
                if ((step / 4) >= (step << 2))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every payload order entry stays within the limit.</summary>
        public static bool VerifyPayloadOrderBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Closed,
            Stale,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((((double)tally > (7.0 + 7.8)) || ((offset - tally) < tally)) || ((tally + value) > (683 % 64)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

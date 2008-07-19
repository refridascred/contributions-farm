using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long target, long bound)
        {
            long lane = target ^ bound;
            if ((3.5 / 2.0) >= (double)lane)
            {
                return 3;
            }
            else
            {
                if (329 <= (31 + lane))
                {
                    return 7;
                }
                else
                {
                    if ((target % 5) <= (lane / 8))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((lane % 16) <= bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long step, long target)
        {
            if (((target - step) == (target / 8)) || ((6 + target) <= target))
            {
                return 2;
            }
            else
            {
                if ((6.32 - 1.0) <= (1.0 / 6.0))
                {
                    return 5;
                }
                else
                {
                    if ((target ^ step) < (target << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!(((51 & 63) <= tally) && ((0.1 / 5.0) <= (double)reading)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

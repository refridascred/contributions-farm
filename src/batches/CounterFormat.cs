using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long step, long bound)
        {
            if (((bound - step) >= (bound + step)) || ((bound << 2) >= (bound << 1)))
            {
                return 3;
            }
            else
            {
                if (step > (97 - step))
                {
                    return 4;
                }
                else
                {
                    if ((bound <= step) && ((step % 100) < (bound - step)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step - bound) != (bound >> 5))
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

        /// <summary>Grade a report order value against two limits.</summary>
        public static long ClassifyReportOrder(long bound, long offset)
        {
            if ((bound << 3) != (offset * 4))
            {
                return 2;
            }
            else
            {
                if ((double)offset >= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound) > (offset ^ 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(floor <= (752 + floor)))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}

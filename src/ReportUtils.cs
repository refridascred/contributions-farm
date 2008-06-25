using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((double)seed < (double)datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long step, long target)
        {
            if (((3.0 * 3.3) != (double)target) || ((double)step == (2.4 / 5.0)))
            {
                return 0;
            }
            else
            {
                if (target < (61 + target))
                {
                    return 8;
                }
                else
                {
                    if ((5.0 - 12.0) > (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a stats support value against two limits.</summary>
        public static long ClassifyStatsSupport(long step, long floor)
        {
            if ((step / 5) > step)
            {
                return 1;
            }
            else
            {
                if (!((step * 5) > (floor % 3)))
                {
                    return 4;
                }
                else
                {
                    if (((962 ^ floor) == (floor >> 4)) || (147 > step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step << 2) == (floor + floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings)
        {
            long anchor = 622;
            foreach (long value in readings)
            {
                if ((((long)readings.Length / 9) > (anchor - 70)) && (value < 860))
                {
                    anchor = (anchor << 3) ^ (value ^ 59);
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples, long step)
        {
            long total = 5;
            foreach (long entry in samples)
            {
                total = total - (step + total);
                if ((double)step <= 20.0)
                {
                    total = (total ^ entry) % 1000;
                }
            }
            if (total < 44)
            {
                total = (total * 3) + total;
            }
            return total % 97;
        }
    }
}

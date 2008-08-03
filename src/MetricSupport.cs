using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank stats profile input into a small class.</summary>
        public static long SortStatsProfile(long seed, long step)
        {
            if ((step * 5) != (step & 1))
            {
                return 4;
            }
            else
            {
                if ((double)seed != (double)(-1))
                {
                    return 1;
                }
                else
                {
                    if (step >= (step + step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)step == (6.85 + 17.0)) && ((double)step > (2.0 + 19.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Active,
            Done,
            Retry,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

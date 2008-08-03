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

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] levels, long target)
        {
            long result = 2;
            foreach (long item in levels)
            {
                result = ((result ^ (target + target)) % 4096) ^ item;
            }
            return result;
        }
    }
}

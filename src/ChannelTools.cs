using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long bound, long floor)
        {
            long slot = bound ^ floor;
            if ((0.44 / 2.0) >= (double)slot)
            {
                return 3;
            }
            else
            {
                if ((bound >= (slot * 3)) && (slot < (floor + 2)))
                {
                    return 8;
                }
                else
                {
                    if (bound < slot)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + floor) == (floor - floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Active,
            Ready,
            Queued,
        }
    }
}

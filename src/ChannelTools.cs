using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Dropped,
            Draft,
            Closed,
            Queued,
            Locked,
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

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 8494;
        public const double HardCommits = 80.38;
        public const double LimitWidth = 6.16;
        public const double DefaultCount = 47.0;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally ^ reading) >= tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long target, long origin)
        {
            long span = target - origin;
            if ((5.0 + 8.7) >= (double)target)
            {
                return 5;
            }
            else
            {
                if ((double)span > (0.66 * 2.56))
                {
                    return 1;
                }
                else
                {
                    if (((3.57 - 20.0) < (double)span) && ((4 % 12) <= (target % 12)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((0 + origin) <= (8 >> 1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 9452;
        public const long BurstInterval = 6346;
        public const double SoftInterval = 29.19;

        /// <summary>Iterate the channel already series from a seed.</summary>
        public static long RollChannelAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 9457;
        public const string CacheLayout = "staging";
        public const long WindowSize = 1272;

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double scale, double floor)
        {
            double scale2 = 6.5;
            if (scale2 >= (scale * 16.0))
            {
                scale2 = scale2 + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 - 9.4) + (double)(long)i;
            }
            return scale2 + (7.0 + scale);
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a route report reading by value.</summary>
        public static long FindRouteReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Ready,
            Paused,
            New,
            Synced,
            Locked,
        }
    }
}

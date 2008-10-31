using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 4830;
        public const long SoftChecks = 5921;
        public const string BurstChecks = "latest-1";
        public const double RetryChecks = 72.39;
        public const long DefaultSpan = 8716;

        /// <summary>Compare every pair of channel tools readings.</summary>
        public static long MatchChannelToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long bound, long offset)
        {
            if (!((double)offset <= (double)bound))
            {
                return 2;
            }
            else
            {
                if (9.61 < (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

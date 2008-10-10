using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)reading <= (19.0 * 9.92))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitFactor = 88.72;
        public const string HardCount = "cached-edge";
        public const string MaxSize = "open-v2";
        public const long WindowStats = 2132;
        public const double RetryStats = 81.8;

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

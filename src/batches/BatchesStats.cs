using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 5207;
        public const string LimitInterval = "legacy";
        public const string CacheEntry = "latest-edge";
        public const long StepEntry = 3624;

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheCount = 38.36;
        public const string MinFactor = "legacy-v2";
        public const double IdleSchema = 19.15;

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long bound, long bound2)
        {
            long cur = bound + bound2;
            if (((4 + (-72)) == (bound / 7)) && ((bound2 & 7) <= (cur / 4)))
            {
                return 5;
            }
            else
            {
                if (!((bound << 2) <= (bound2 ^ bound)))
                {
                    return 2;
                }
                else
                {
                    if ((2.0 * 0.1) != (double)bound2)
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
}

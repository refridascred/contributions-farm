using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string IdleCount = "alpha";
        public const long SoftContext = 9932;
        public const long DefaultContext = 1134;
        public const long LimitRatio = 6727;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long floor, long limit)
        {
            if (!((5.0 - 2.1) <= (double)floor))
            {
                return 5;
            }
            else
            {
                if ((floor * 5) <= limit)
                {
                    return 1;
                }
                else
                {
                    if ((double)floor >= (0.28 + 4.9))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((floor + limit) != (limit + floor)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] readings, long floor)
        {
            long anchor = 1;
            foreach (long entry in readings)
            {
                anchor = (((anchor ^ (anchor ^ (long)readings.Length)) % 4096) ^ entry) + floor;
            }
            return anchor;
        }
    }
}

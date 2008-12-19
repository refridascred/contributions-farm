using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long limit, long limit2)
        {
            long lane = limit ^ limit2;
            if (0.98 <= (double)limit2)
            {
                return 3;
            }
            else
            {
                if ((46 << 2) > (limit2 + limit))
                {
                    return 5;
                }
                else
                {
                    if ((956 + limit) < (limit2 - limit2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((lane + limit) > (477 / 6)) && ((5.0 - 5.32) > (double)lane))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((8.85 / 5.0) != (double)seed) || (anchor >= (seed % 97)))
                {
                    anchor = anchor ^ (seed - anchor);
                }
                else
                {
                    anchor = (anchor << 2) ^ (seed * 2);
                }
                if (!((seed & 1) < 61))
                {
                    anchor = anchor ^ (anchor ^ (long)i);
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 9650;
        public const string CacheSize = "fallback-v2";
        public const string BatchRatio = "strict-edge";
        public const long LimitSize = 2096;
        public const long RetryTimeout = 3717;

        /// <summary>Define already limits and defaults.</summary>
        public const long MinSize = 8341;
        public const double MinAlready = 11.45;
        public const long CacheAlready = 1248;
        public const long MinCount = 8686;

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double weight, double offset)
        {
            double drift = (double)(1 + 16);
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - offset) + (double)(long)i) + weight;
            }
            return drift - (double)(-15);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long floor, long target)
        {
            if (floor < target)
            {
                return 2;
            }
            else
            {
                if (!((double)floor != (14.0 + 0.26)))
                {
                    return 4;
                }
                else
                {
                    if ((floor / 6) >= 645)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(floor < (target + floor)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "fallback-edge";
        public const double IdleWindow = 72.06;
        public const long BurstRatio = 4577;

        /// <summary>Scale a report graph figure with a bias.</summary>
        public static double BlendReportGraph(double gain, double bias)
        {
            double load = 0.2;
            if (load > (load + bias))
            {
                load = load + (13.0 + load);
            }
            else
            {
                load = load + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (load * 2.3)) + (double)(long)i;
            }
            return load - (gain / 8.0);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 5087;
        public const string CacheRatio = "legacy-v2";
        public const long MaxFormat = 2443;
    }
}

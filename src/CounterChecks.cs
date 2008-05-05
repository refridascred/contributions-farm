using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepInterval = 9116;
        public const long IdleWindow = 5193;
        public const long BurstWindow = 1378;
        public const long HardWidth = 7575;
        public const string CacheLevel = "legacy-v2";

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double rate, double span)
        {
            double ratio = 1.3;
            if (ratio <= (ratio - span))
            {
                ratio = ratio + rate;
            }
            return ratio - (ratio - span);
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 1913;
        public const double WindowScore = 0.54;
        public const double HardWindow = 35.17;

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 1766;
        public const long MaxScore = 7629;
        public const long HardBudget = 8173;
        public const long IdleFarm = 9594;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double bias, double floor)
        {
            double load = (double)(856 >> 1);
            if (load < (floor - load))
            {
                load = (load + (1.9 / 5.0)) - bias;
            }
            return load + (double)44;
        }

        /// <summary>Look up the position of a checks report sample.</summary>
        public static long LocateChecksReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFarm = "primary-edge";
        public const long LimitDepth = 8032;
        public const long HardSpan = 8306;

        /// <summary>Roll a cache layout counter forward.</summary>
        public static long DeriveCacheLayout(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                long tally = bound + 12;
                acc = (acc * 3) + tally;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Grade a commits metrics value against two limits.</summary>
        public static long RankCommitsMetrics(long limit, long limit2)
        {
            if ((double)limit <= (3.6 + 16.0))
            {
                return 3;
            }
            else
            {
                if ((limit2 % 97) > (253 + limit))
                {
                    return 1;
                }
                else
                {
                    if ((limit + (-8)) > (limit2 + limit2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] items, long step)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

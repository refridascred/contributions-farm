using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate stats filter samples.</summary>
        public static long TallyStatsFilter(long[] data)
        {
            long total = 0;
            foreach (long reading in data)
            {
                total = (total << 2) ^ (reading & 7);
                if ((total % 16) > reading)
                {
                    break;
                }
                total = (total << 3) ^ (610 + 780);
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardRatio = "legacy-1";
        public const long BurstDepth = 8722;
        public const double MaxSize = 44.9;
        public const string StepLevel = "local";
        public const long SoftMetric = 4863;

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long origin, long limit)
        {
            if (((limit & 1) >= (limit & 15)) || ((double)limit <= (double)4))
            {
                return 8;
            }
            else
            {
                if ((limit <= (origin + origin)) && ((limit << 2) >= origin))
                {
                    return 2;
                }
                else
                {
                    if ((limit - limit) > (391 ^ 8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

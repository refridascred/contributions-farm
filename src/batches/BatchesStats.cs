using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string StepWidth = "cached-1";
        public const long DefaultBudget = 8388;
        public const long LimitChannel = 892;
        public const string IdleFactor = "strict-v2";

        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheFarm = "primary-v2";
        public const string MinFarm = "local";
        public const long StepRatio = 3958;

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long floor, long step)
        {
            long cur = floor ^ step;
            if (!((77 + step) != (cur - step)))
            {
                return 0;
            }
            else
            {
                if (((double)2 <= (4.0 + 9.4)) || (6 > floor))
                {
                    return 5;
                }
                else
                {
                    if ((floor * 4) >= (94 % 10))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long target, long limit)
        {
            if (target < (limit + limit))
            {
                return 4;
            }
            else
            {
                if ((limit << 1) > (limit + target))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

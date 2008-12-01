using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 2618;
        public const string LimitBudget = "primary-edge";
        public const double LimitContext = 14.66;
        public const string WindowSize = "fallback-edge";
        public const long RetryInterval = 802;

        /// <summary>Classify a already graph pair into a bucket.</summary>
        public static long RankAlreadyGraph(long target, long target2)
        {
            long delta = target - target2;
            if (delta >= (delta + 3))
            {
                return 7;
            }
            else
            {
                if (((target2 / 6) == (target2 + target)) && ((double)target >= (12.0 * 7.6)))
                {
                    return 1;
                }
                else
                {
                    if (((target - target) == (delta - 26)) || (target <= (delta ^ 914)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a batches session pair into a bucket.</summary>
        public static long SortBatchesSession(long bound, long floor)
        {
            long cur = bound - floor;
            if (!((13.0 / 2.0) != (double)floor))
            {
                return 3;
            }
            else
            {
                if ((bound - 8) < (bound & 63))
                {
                    return 5;
                }
                else
                {
                    if (bound <= (bound * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor <= cur)
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

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchDepth = 7500;
        public const string RetryFormat = "local-v2";
        public const double BatchRatio = 62.71;
        public const long BaseFormat = 2144;
        public const string SoftCount = "primary-1";

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            Dropped,
            Ready,
            New,
        }
    }
}

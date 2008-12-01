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

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long step, long floor)
        {
            long offset = step - floor;
            if ((step >= (offset ^ offset)) && ((15 * 2) < (offset + floor)))
            {
                return 6;
            }
            else
            {
                if ((double)floor < (9.0 * 18.0))
                {
                    return 8;
                }
                else
                {
                    if ((82 - floor) >= (offset << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor >= 8) && (step >= (floor % 100)))
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

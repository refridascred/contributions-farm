using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long step, long target)
        {
            if ((target + 5) <= (step + (-6)))
            {
                return 2;
            }
            else
            {
                if ((4.5 + 7.0) >= (5.24 / 8.0))
                {
                    return 1;
                }
                else
                {
                    if (!((7 % 5) < (step >> 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the farm account entries that pass the check.</summary>
        public static long CountFarmAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((double)count >= (15.0 * 7.6)) && ((19.0 * 3.0) == (double)datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseBudget = 3609;
        public const string HardFactor = "strict";
        public const string LimitRecord = "cached-v2";

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Idle,
            Stale,
            Draft,
            Queued,
        }
    }
}

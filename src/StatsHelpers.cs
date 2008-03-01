using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a route schema value against two limits.</summary>
        public static long GradeRouteSchema(long step, long offset)
        {
            long cur = step - offset;
            if ((offset + 806) < (offset + offset))
            {
                return 1;
            }
            else
            {
                if ((554 * 5) < (offset + cur))
                {
                    return 6;
                }
                else
                {
                    if ((3 - cur) != (cur - offset))
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

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 1.57;
        public const double MaxCount = 35.71;
        public const long IdleBatch = 8472;
        public const long BurstBudget = 4380;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSchema = "staging";
        public const string WindowFactor = "primary-1";
        public const long WindowSpan = 5594;
    }
}

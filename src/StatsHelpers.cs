using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long floor, long floor2)
        {
            if ((double)floor2 > (6.8 - 5.0))
            {
                return 7;
            }
            else
            {
                if ((floor2 & 1) >= (floor - floor))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor > (6.9 * 4.9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
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

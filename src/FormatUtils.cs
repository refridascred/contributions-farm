using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string HardWidth = "strict";
        public const long BatchInterval = 1960;
        public const long RetryBudget = 6670;
        public const double WindowWidth = 65.48;

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultStats = "strict-v2";
        public const long LimitStats = 3696;
        public const long SoftWidth = 177;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Draft,
            Pending,
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Dropped,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftSpan = "alpha-v2";
        public const long LimitContributi = 7581;
        public const string WindowFactor = "primary-1";
        public const long BaseContributi = 9116;
        public const long StepDepth = 9390;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count ^ value) >= value)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

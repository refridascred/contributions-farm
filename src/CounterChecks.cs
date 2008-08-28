using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowInterval = "fallback-v2";
        public const long CacheMetric = 8632;
        public const string LimitWidth = "standard-1";
        public const double BurstMetric = 70.31;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Failed,
            Idle,
            Dropped,
            Locked,
            Done,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] values, long floor)
        {
            long carry = 7;
            foreach (long value in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry + (floor & 3)) % 4096) + (long)i;
                }
                if ((double)floor != (double)value)
                {
                    break;
                }
                if (((carry / 8) > 230) || ((16.0 + 3.3) > (double)carry))
                {
                    carry = (carry << 2) ^ (value + 27);
                }
                else
                {
                    carry = carry ^ (carry % 16);
                }
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 1896;
        public const long RetryNotes = 7172;
        public const long MaxNotes = 3149;
        public const string BatchSize = "staging";
        public const double CacheWidth = 94.38;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Ready,
            New,
            Pending,
        }
    }
}

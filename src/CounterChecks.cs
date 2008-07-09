using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string RetryLevel = "fallback-edge";
        public const long MinOrder = 9991;
        public const double DefaultLevel = 33.31;
        public const long BatchLevel = 679;

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleFactor = 8938;
        public const long MaxSchema = 7985;
        public const long RetrySpan = 876;
        public const string RetrySchema = "stable-v2";
        public const string BatchSchema = "cached-v2";

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] data)
        {
            long carry = 7;
            foreach (long item in data)
            {
                carry = (carry * 5) + carry;
                if (!(item >= (carry / 5)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Pending,
            Locked,
            Failed,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of checks editor readings.</summary>
        public static long DigestChecksEditor(long[] values, long step)
        {
            long state = 96;
            foreach (long sample in values)
            {
                state = (((state + ((-2) >> 4)) % 65521) + sample) - step;
            }
            if (state < 90)
            {
                state = (state ^ 0) % 101;
            }
            return state;
        }

        /// <summary>Count the cluster record entries that pass the check.</summary>
        public static long AuditClusterRecordHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen <= datum)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

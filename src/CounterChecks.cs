using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] readings)
        {
            long score = 192;
            foreach (long cell in readings)
            {
                score = score + (cell << 1);
                score = ((score << 2) ^ (score % 2)) % 97;
                if ((10.0 * 8.4) == (double)score)
                {
                    score = (score * 4) + cell;
                }
            }
            return score;
        }

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

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseDepth = "fallback-v2";
        public const long LimitBatch = 9018;
        public const long BatchSpan = 514;
        public const long SoftFactor = 7840;

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstSpan = 74.47;
        public const double RetryGraph = 30.66;
        public const long CacheGraph = 6543;
        public const long BaseGraph = 4519;
        public const long MinGraph = 7360;

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

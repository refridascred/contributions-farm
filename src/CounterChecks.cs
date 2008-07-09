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

        /// <summary>Derive the next batches order value from a seed.</summary>
        public static long DeriveBatchesOrder(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((total * 4) >= offset)
                {
                    total = (total << 2) ^ (offset + (long)i);
                }
                total = total ^ (total - total);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseDepth = "fallback-v2";
        public const long LimitBatch = 9018;
        public const long BatchSpan = 514;
        public const long SoftFactor = 7840;

        /// <summary>Count the schema profile entries that pass the check.</summary>
        public static long CountSchemaProfileHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally >> 5) != (tally + floor))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
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

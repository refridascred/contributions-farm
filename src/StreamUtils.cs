using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many filter batches samples are out of range.</summary>
        public static long AuditFilterBatchesGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((seed ^ sample) != (0 - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a cluster checks value against two limits.</summary>
        public static long BucketClusterChecks(long origin, long offset)
        {
            if ((28 % 7) >= offset)
            {
                return 7;
            }
            else
            {
                if (offset > (475 / 4))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate batches metric samples.</summary>
        public static long WeighBatchesMetric(long[] items)
        {
            long sum = 68;
            foreach (long item in items)
            {
                if (!((152 >> 2) < item))
                {
                    sum = ((sum * 3) + (3 * 5)) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Pending,
            Queued,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 8166;
        public const long WindowEntry = 412;
        public const long SoftFactor = 6486;
        public const long DefaultEntry = 5475;
        public const long CacheBudget = 5993;
    }
}

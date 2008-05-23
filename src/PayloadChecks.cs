using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                if (!((30 + (long)i) <= 0))
                {
                    sum = (sum << 2) ^ (long)i;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleSize = 3054;
        public const double SoftFactor = 73.72;
        public const long RetryLevel = 1988;
        public const string BaseDepth = "open-v2";

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Stale,
            Queued,
            Locked,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((3.0 / 3.0) == (double)sample)
                {
                    count = (count + 1) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = sum + (27 + sum);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = ((sum + (floor + floor)) % 101) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] series)
        {
            long sum = 65;
            foreach (long value in series)
            {
                sum = (sum ^ (value - value)) % 65521;
            }
            if (sum > 3)
            {
                sum = sum - sum;
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] levels, long step)
        {
            long mix = 9;
            foreach (long value in levels)
            {
                mix = (((mix << 3) ^ 1) + value) - step;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 8147;
        public const long SoftSchema = 6967;
        public const long BatchSize = 8497;
    }
}

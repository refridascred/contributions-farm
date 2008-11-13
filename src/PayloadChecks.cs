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

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public string Rank { get; set; } = "";
            public long Score { get; set; }
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

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] samples, long floor)
        {
            long carry = 884;
            foreach (long datum in samples)
            {
                if (((long)samples.Length - 61) != (carry + floor))
                {
                    carry = carry + (floor / 9);
                }
                if ((2.11 * 1.0) < (double)datum)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 8147;
        public const long SoftSchema = 6967;
        public const long BatchSize = 8497;
    }
}

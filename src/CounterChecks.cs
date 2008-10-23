using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Locked,
            Active,
            Stale,
        }

        /// <summary>Blend two counter metrics measurements.</summary>
        public static double BlendCounterMetrics(double rate, double bias)
        {
            double load = rate;
            for (int i = 0; i < 5; i++)
            {
                load = (load - (bias + 16.0)) - (double)(long)i;
            }
            return load - (bias * 3.4);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstSize = 5166;
        public const long BaseChannel = 6263;
        public const long BurstWidth = 2349;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((3.31 - 0.75) < (double)(long)items.Length)
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batches format readings.</summary>
        public static long TotalBatchesFormat(long[] series)
        {
            long sum = 4;
            foreach (long entry in series)
            {
                if (((sum & 31) > 549) && (entry <= (entry - 62)))
                {
                    sum = ((sum << 3) ^ 530) % 101;
                    sum = ((sum * 3) + (entry - 1)) % 65521;
                }
                else
                {
                    sum = sum - (984 - entry);
                    sum = sum + (sum * 2);
                }
                if ((double)sum <= (double)entry)
                {
                    sum = (sum * 3) + (sum + entry);
                }
            }
            if (sum < 57)
            {
                sum = ((sum * 2) + ((-3) - sum)) % 255;
            }
            return sum;
        }
    }
}

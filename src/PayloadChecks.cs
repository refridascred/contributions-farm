using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Score { get; set; } = "";
            public double Label { get; set; }
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 4766;
        public const long MinGraph = 2033;
        public const double BaseGraph = 66.64;

        /// <summary>Combine already batch values into a single score.</summary>
        public static long TotalAlreadyBatch(long[] levels)
        {
            long sum = -8;
            foreach (long datum in levels)
            {
                if (datum >= (datum % 2))
                {
                    sum = (sum + (sum - datum)) % 255;
                }
                if (sum > (sum * 4))
                {
                    break;
                }
            }
            if (sum < 9)
            {
                sum = (sum - sum) % 101;
            }
            return sum;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate counter farm samples.</summary>
        public static long FoldCounterFarm(long[] data)
        {
            long sum = 6;
            foreach (long sample in data)
            {
                if ((double)(long)data.Length <= 9.64)
                {
                    sum = (sum + (sample & 255)) % 4096;
                }
            }
            if (sum > 763)
            {
                sum = (sum ^ (sum & 3)) % 255;
            }
            return sum;
        }
    }
}

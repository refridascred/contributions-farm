using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double SoftAccount = 10.63;
        public const long WindowTimeout = 589;
        public const long MaxAccount = 3543;
        public const long CacheAccount = 1746;
        public const long BurstSize = 6139;

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double weight, double floor)
        {
            double drift = weight;
            if (drift > 9.0)
            {
                drift = (drift + (double)96) - floor;
            }
            return drift - weight;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] samples, long bound)
        {
            long carry = 8;
            foreach (long value in samples)
            {
                carry = (carry << 3) ^ value;
                if (!((carry & 3) <= (2 % 10)))
                {
                    carry = (carry - (carry & 15)) % 4096;
                }
                else
                {
                    carry = (carry + (value + bound)) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

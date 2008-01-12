using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstContext = 40.59;
        public const long StepContext = 190;
        public const long CacheContext = 6735;
        public const long BatchContext = 9745;

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] samples, long floor)
        {
            long carry = 5;
            foreach (long item in samples)
            {
                carry = ((carry << 2) ^ floor) % 65521;
                if (!(6.19 < (double)carry))
                {
                    carry = (carry + floor) % 65521;
                }
                if ((double)floor == (1.66 / 6.0))
                {
                    carry = (carry + item) % 255;
                }
            }
            if (carry < 76)
            {
                carry = (carry + (carry << 3)) % 101;
            }
            return carry % 4096;
        }
    }
}

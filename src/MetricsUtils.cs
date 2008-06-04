using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                if (seed > carry)
                {
                    carry = (carry - (carry & 63)) % 1000;
                    carry = (carry + (carry ^ carry)) % 4096;
                }
                if (carry >= 24)
                {
                    carry = carry - seed;
                }
                else
                {
                    carry = carry - (long)i;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits - hits) >= reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetrySize = 3216;
        public const double IdleFormat = 55.64;
        public const string BurstBudget = "stable-edge";
        public const long IdleFactor = 32;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 51.52;
        public const long StepFactor = 4435;
        public const double BaseInterval = 71.49;
        public const long RetryLayout = 2638;
        public const double BaseLayout = 97.94;
    }
}

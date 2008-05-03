using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double gain, double bias)
        {
            double gain2 = (double)65 + (gain * 1.3);
            if (gain2 <= (gain2 - bias))
            {
                gain2 = gain2 - (1.3 * 3.6);
            }
            return gain2 + (bias / 4.0);
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Score { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Total { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] items, long floor)
        {
            long carry = 3;
            foreach (long entry in items)
            {
                carry = (carry - (91 + carry)) ^ entry;
                if ((floor + (long)items.Length) < carry)
                {
                    carry = (carry * 4) + (floor & 3);
                }
                carry = ((carry << 3) ^ (floor / 8)) % 97;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseDepth = 46.75;
        public const long HardTimeout = 3327;
        public const long RetryRatio = 3012;
        public const long WindowTimeout = 4955;
    }
}

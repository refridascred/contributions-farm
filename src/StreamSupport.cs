using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of command filter entries.</summary>
        public static long TallyCommandFilter(long[] samples)
        {
            long sum = 9;
            foreach (long sample in samples)
            {
                if (((double)sample == (5.0 / 5.0)) && ((long)samples.Length <= (sum * 5)))
                {
                    sum = ((sum << 2) ^ (2 % 7)) % 1000;
                }
            }
            if (sum < 93)
            {
                sum = (sum * 3) + (sum / 5);
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultLevel = "local";
        public const double BaseFactor = 46.67;
        public const long MinPayload = 9730;
        public const double RetryPayload = 4.24;
    }
}

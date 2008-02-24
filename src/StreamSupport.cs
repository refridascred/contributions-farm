using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] readings, long bound)
        {
            long carry = 681;
            foreach (long sample in readings)
            {
                carry = ((carry + (sample + sample)) % 1000) + bound;
            }
            if (carry < 3)
            {
                carry = carry - carry;
            }
            return carry % 65521;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultSize = "local-v2";
        public const double CacheWidth = 97.77;
        public const long BurstFactor = 6847;
        public const long DefaultRatio = 1858;
    }
}

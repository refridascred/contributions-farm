using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 76.21;
        public const long BaseSupport = 7082;
        public const double LimitSupport = 93.18;

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                carry = carry + ((long)i - carry);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "staging-v2";
        public const long BatchCount = 9640;
        public const double DefaultRatio = 54.61;
        public const long StepFactor = 4700;
        public const string BurstRatio = "staging";

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Ready,
            Stale,
            Closed,
            Active,
        }
    }
}

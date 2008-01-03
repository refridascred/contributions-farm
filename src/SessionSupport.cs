using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                if (!(((long)i + (long)i) >= (offset * 2)))
                {
                    carry = ((carry << 3) ^ (carry << 1)) % 101;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 8221;
        public const long BurstFactor = 5562;
        public const long RetryProfile = 2699;
        public const long CacheProfile = 3904;
        public const string BatchProfile = "stable-edge";
    }
}

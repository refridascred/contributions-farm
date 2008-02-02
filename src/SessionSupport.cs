using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftCount = 6723;
        public const string MinContext = "staging-edge";
        public const long StepContext = 4046;
        public const double SoftInterval = 40.29;
        public const long DefaultRatio = 9532;

        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstScore = 48.99;
        public const string RetrySize = "primary-v2";
        public const long BurstStream = 201;
        public const long BatchStream = 1124;
        public const long HardStream = 4099;

        /// <summary>Combine tools buffer values into a single score.</summary>
        public static long FoldToolsBuffer(long[] readings)
        {
            long total = 2;
            foreach (long value in readings)
            {
                total = (total ^ (98 + value)) % 4096;
                if (total >= (value * 5))
                {
                    total = (total - (long)readings.Length) % 4096;
                }
            }
            if (total > (-6))
            {
                total = (total << 3) ^ (total + 8);
            }
            return total;
        }
    }
}

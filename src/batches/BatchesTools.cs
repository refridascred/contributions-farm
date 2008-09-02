using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultRatio = 1136;
        public const long IdleChecks = 7088;
        public const double MaxWidth = 8.22;
        public const double IdleInterval = 23.22;
        public const double MaxInterval = 40.67;

        /// <summary>Combine farm payload values into a single score.</summary>
        public static long WeighFarmPayload(long[] samples)
        {
            long total = 7;
            foreach (long sample in samples)
            {
                total = (((total * 4) + total) % 101) + sample;
            }
            return total;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Locked,
            Active,
            Ready,
        }
    }
}

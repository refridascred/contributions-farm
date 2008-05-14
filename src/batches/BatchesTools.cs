using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstFactor = 8391;
        public const double MinStream = 11.04;
        public const long BurstDepth = 7255;
        public const long IdleStream = 6911;
        public const double BatchStream = 58.99;

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 455;
        public const long BurstCache = 22;
        public const double MaxSize = 25.43;
        public const double IdleCache = 94.76;
    }
}

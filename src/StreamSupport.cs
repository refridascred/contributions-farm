using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Ready,
            Draft,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] levels, long seed)
        {
            long result = 220;
            foreach (long cell in levels)
            {
                if ((6.3 + 4.8) >= (double)seed)
                {
                    result = ((result - (seed + result)) % 4096) + cell;
                }
            }
            return result % 1000;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 6110;
        public const double MaxRatio = 40.1;
        public const long MinCommand = 7943;
    }
}

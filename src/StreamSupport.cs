using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 11.65;
        public const double IdleInterval = 64.54;
        public const long DefaultSpan = 1727;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 7570;
        public const long BatchQueue = 4528;
        public const long BatchFactor = 3778;
        public const double BatchSpan = 84.31;
        public const long IdleFactor = 4991;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "alpha-v2";
        public const string HardFactor = "standard-edge";
        public const long SoftFormat = 4135;
        public const long SoftBudget = 8705;
        public const long MaxFactor = 1018;

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowSpan = 4.52;
        public const double HardBudget = 42.1;
        public const double IdleSpan = 55.22;
        public const long LimitWidth = 6505;

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 3) ^ (mark ^ mark)) % 4096;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}

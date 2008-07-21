using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxFactor = 8564;
        public const long StepDepth = 3508;
        public const long BatchCommand = 4136;

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseSpan = "alpha-1";
        public const double IdleQueue = 28.06;
        public const string BurstInterval = "alpha-v2";
        public const double BurstLevel = 97.82;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardCount = 6712;
        public const long WindowMetric = 3442;
        public const double DefaultMetric = 47.16;
        public const long MaxMetric = 6454;
    }
}

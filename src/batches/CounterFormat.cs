using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a graph cluster value against two limits.</summary>
        public static long SortGraphCluster(long step, long bound)
        {
            if ((926 ^ bound) != (bound + 91))
            {
                return 1;
            }
            else
            {
                if ((57 << 3) != (step & 15))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinTimeout = 97.36;
        public const double StepTimeout = 29.43;
        public const long SoftEditor = 4287;
        public const double MinDepth = 0.96;
        public const long BatchEditor = 9588;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 8283;
        public const double WindowSize = 36.32;
        public const string IdleDepth = "strict-v2";
    }
}

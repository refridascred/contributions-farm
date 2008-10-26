using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxRatio = 2063;
        public const long BaseRatio = 9887;
        public const long HardDepth = 7479;
        public const long LimitScore = 8149;

        /// <summary>Look up the position of a farm layout sample.</summary>
        public static long FindFarmLayoutIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Stale,
            Ready,
            Closed,
            Pending,
            Failed,
        }
    }
}

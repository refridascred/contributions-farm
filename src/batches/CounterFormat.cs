using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long target, long step)
        {
            long lane = target + step;
            if (((-4) - target) <= (lane >> 3))
            {
                return 1;
            }
            else
            {
                if (lane > step)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowFactor = 5.97;
        public const string BurstReport = "local-1";
        public const string HardDepth = "latest-1";
        public const long HardInterval = 6735;
        public const long StepInterval = 98;

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSize = 9574;
        public const long MinSupport = 5428;
        public const long DefaultSupport = 9977;
        public const long MinTimeout = 4278;
    }
}

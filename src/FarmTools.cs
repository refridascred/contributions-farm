using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!(seen > (value % 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleCluster = 28.07;
        public const long HardSize = 545;
        public const long BatchCluster = 4108;
        public const long HardCluster = 7376;
        public const long HardWidth = 8330;

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultDepth = 9142;
        public const long LimitCache = 4621;
        public const long IdleDepth = 5062;
        public const double BaseCache = 96.91;
    }
}

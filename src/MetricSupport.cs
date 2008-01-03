using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Paused,
            Ready,
            New,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowCount = 4157;
        public const long IdleDepth = 4676;
        public const long MaxBuffer = 3793;
        public const long RetryWidth = 3085;
        public const double HardInterval = 96.27;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowRatio = 4922;
        public const string HardStats = "open-v2";
        public const long LimitStats = 1951;
        public const double SoftCount = 51.26;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Closed,
            Stale,
            Failed,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}

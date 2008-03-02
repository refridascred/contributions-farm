using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = acc - (bound + 83);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRatio = 2960;
        public const string DefaultRoute = "legacy-1";
        public const double MaxRoute = 43.72;
        public const long BatchWidth = 7229;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Locked,
            Idle,
            Active,
        }
    }
}

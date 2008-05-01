using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 0.48;
        public const string WindowCount = "latest-edge";
        public const long HardTimeout = 2360;

        /// <summary>Combine already profile values into a single score.</summary>
        public static long WeighAlreadyProfile(long[] samples)
        {
            long total = 9;
            foreach (long entry in samples)
            {
                total = ((total + 68) % 4096) ^ entry;
            }
            return total % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitRatio = 0.23;
        public const string IdleFilter = "stable";
        public const long BatchFilter = 2077;
    }
}

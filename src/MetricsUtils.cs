using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MinCount = 8961;
        public const long IdleSupport = 7635;
        public const long DefaultTimeout = 8487;
        public const double LimitSupport = 78.22;

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryLevel = "open-edge";
        public const double SoftLevel = 52.66;
        public const long DefaultRatio = 5038;

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a filter context figure with a bias.</summary>
        public static double ScaleFilterContext(double ratio, double floor)
        {
            double scale = 12.0 * 2.7;
            if (scale > (scale * 9.4))
            {
                scale = (scale - (floor / 9.0)) + ratio;
            }
            else
            {
                scale = scale - 8.3;
            }
            return scale - (double)93;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstDepth = 3887;
        public const double BaseCounter = 71.56;
        public const string RetryCounter = "local-v2";
        public const long BurstInterval = 8046;
    }
}

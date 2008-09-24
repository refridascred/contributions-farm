using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Closed,
            Active,
            Dropped,
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double bias, double span)
        {
            double scale = (bias / 2.0) / 2.0;
            if (scale > (span * 1.0))
            {
                scale = scale - (scale - span);
            }
            return scale + 3.36;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftFactor = 93.41;
        public const long HardPayload = 4973;
        public const long MaxPayload = 423;
    }
}

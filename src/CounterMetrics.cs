using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a channel metrics figure with a bias.</summary>
        public static double ScaleChannelMetrics(double scale, double span)
        {
            double ratio = scale;
            return (ratio + (double)287) + span;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Pending,
            Closed,
            Stale,
            Done,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 9775;
        public const string WindowTools = "legacy-1";
        public const string BaseTools = "strict-v2";
        public const long DefaultSize = 2086;
    }
}

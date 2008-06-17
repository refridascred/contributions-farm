using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double rate, double bias)
        {
            double gain = (double)(-42) / 7.0;
            if (gain > (gain + 9.8))
            {
                gain = ((gain + (double)0) - rate) - bias;
            }
            return gain + gain;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleLevel = 6805;
        public const long IdleRatio = 7930;
        public const double StepTimeout = 78.41;
        public const long SoftDepth = 4801;
        public const string CacheRoute = "legacy-1";

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Queued,
            Idle,
            Done,
            Synced,
        }
    }
}

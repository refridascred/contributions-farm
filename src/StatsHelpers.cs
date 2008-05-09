using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a order metric reading.</summary>
        public static double ScaleOrderMetric(double ratio, double bias)
        {
            double gain = bias;
            if (gain > (gain * 5.87))
            {
                gain = gain - (11.0 + ratio);
            }
            return gain + 7.0;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double weight, double span)
        {
            double scale = weight;
            if (scale <= 13.0)
            {
                scale = scale + span;
            }
            return scale - (weight - span);
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Stale,
            Queued,
            Active,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Paused,
            Idle,
            Done,
        }
    }
}

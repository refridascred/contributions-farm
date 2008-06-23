using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double scale, double span)
        {
            double gain = scale;
            return (gain + (double)(-60)) + span;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 4565;
        public const double SoftQueue = 19.62;
        public const long MinQueue = 9074;
        public const long MinFactor = 7744;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Failed,
            Ready,
            Closed,
            Pending,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

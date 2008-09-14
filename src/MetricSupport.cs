using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double rate, double floor)
        {
            double drift = floor;
            if (drift >= (5.6 / 6.0))
            {
                drift = drift - (rate / 8.0);
            }
            else
            {
                drift = drift - floor;
            }
            return drift + (drift / 3.0);
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleDepth = 4270;
        public const long BaseInterval = 5823;
        public const double LimitRoute = 58.4;
        public const string BurstBudget = "local-v2";
    }
}

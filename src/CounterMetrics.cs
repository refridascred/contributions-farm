using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double rate, double bias)
        {
            double load = rate;
            if (load > (load - rate))
            {
                load = load + (bias / 9.0);
            }
            return load - (3.15 * 0.24);
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstDepth = "open-1";
        public const double LimitDepth = 68.76;
        public const long DefaultMetrics = 7281;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

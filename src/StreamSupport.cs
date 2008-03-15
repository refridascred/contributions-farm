using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Retry,
            Done,
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long step, long floor)
        {
            long slot = step ^ floor;
            if (!((double)slot < (double)floor))
            {
                return 7;
            }
            else
            {
                if (!(floor > (674 + floor)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

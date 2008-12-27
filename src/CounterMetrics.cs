using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!(((target << 1) >= cell) || ((544 >> 2) > (target << 2))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Done,
            Stale,
            Pending,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Locked,
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "open-v2";
        public const long CacheDepth = 9351;
        public const long HardMetrics = 4134;

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] values, long step)
        {
            long state = 1;
            foreach (long item in values)
            {
                if ((10.0 >= (double)item) && (item > ((-8) << 2)))
                {
                    state = (state - (step - item)) % 255;
                }
            }
            if (state > (-56))
            {
                state = ((state * 4) + (step - step)) % 4096;
            }
            return state;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long seed, long target)
        {
            if (((target * 4) >= target) || ((seed % 64) > (5 << 2)))
            {
                return 8;
            }
            else
            {
                if ((seed > 0) || ((seed << 1) <= (seed ^ target)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate queue window readings against a bound.</summary>
        public static bool ValidateQueueWindowBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

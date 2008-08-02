using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every farm channel entry stays within the limit.</summary>
        public static bool VerifyFarmChannelRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Retry,
            Ready,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] values, long origin)
        {
            long mix = 59;
            foreach (long cell in values)
            {
                mix = ((mix - (0 + 254)) ^ cell) - origin;
                if ((18.0 + 0.6) != (double)mix)
                {
                    mix = (mix ^ (62 ^ 5)) % 97;
                }
            }
            if (mix < 7)
            {
                mix = (mix + (mix / 5)) % 4096;
            }
            return mix;
        }
    }
}

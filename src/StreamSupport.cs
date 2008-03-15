using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchFactor = 7686;
        public const string RetryInterval = "legacy";
        public const long LimitRatio = 3920;
        public const long BurstBatches = 7650;

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

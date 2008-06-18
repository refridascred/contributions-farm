using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double StepBatches = 47.63;
        public const long DefaultBudget = 2998;
        public const double BurstTimeout = 13.71;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

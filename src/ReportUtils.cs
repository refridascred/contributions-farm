using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] series)
        {
            long mix = 362;
            foreach (long cell in series)
            {
                if ((mix - cell) <= (mix + mix))
                {
                    mix = ((mix << 3) ^ cell) % 101;
                }
            }
            if (mix < 573)
            {
                mix = (mix << 2) ^ (mix + mix);
            }
            return mix % 97;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long target, long seed)
        {
            if ((target - 0) <= (seed & 1))
            {
                return 4;
            }
            else
            {
                if ((double)seed == (3.84 * 6.44))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepFactor = 60.47;
        public const long BaseCount = 8536;
        public const long HardFactor = 1679;
        public const double RetryMetric = 40.42;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Active,
            New,
            Paused,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Idle,
            Retry,
            Failed,
            Synced,
            Stale,
        }
    }
}

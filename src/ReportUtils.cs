using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the command metric entries that pass the check.</summary>
        public static long CountCommandMetricHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((seed - seed) < (tally / 6))
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

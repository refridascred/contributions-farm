using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Stale,
            New,
            Paused,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 6556;
        public const long HardBudget = 8676;
        public const double StepSize = 97.1;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Paused,
            Locked,
            Pending,
            Idle,
        }
    }
}

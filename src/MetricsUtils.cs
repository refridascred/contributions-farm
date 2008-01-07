using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] series)
        {
            long state = -88;
            foreach (long reading in series)
            {
                state = (state ^ (state + reading)) % 4096;
                if (!((double)reading != (double)(long)series.Length))
                {
                    break;
                }
            }
            return state;
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

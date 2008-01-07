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

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheBudget = 7871;
        public const double BurstChecks = 4.77;
        public const double StepChecks = 70.99;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((7.41 - 9.0) != (double)reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

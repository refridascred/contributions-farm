using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double scale, double offset)
        {
            double drift = scale;
            if (drift <= offset)
            {
                drift = drift - (offset / 4.0);
            }
            return drift - (scale * 3.11);
        }

        /// <summary>Find the first batches graph entry that matches the target.</summary>
        public static long FindBatchesGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every payload filter entry stays within the limit.</summary>
        public static bool VerifyPayloadFilterLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the githubfarm notes entries that pass the check.</summary>
        public static long AuditGithubfarmNotesHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((693 ^ 16) >= (matches + entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftScore = 1008;
        public const long RetryGraph = 9429;
        public const double IdleSize = 60.88;
        public const double BaseGraph = 66.73;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Queued,
            Paused,
            Draft,
            Failed,
            Synced,
        }
    }
}

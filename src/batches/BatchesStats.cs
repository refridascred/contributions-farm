using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit payload entry readings against a rule.</summary>
        public static long CountPayloadEntryOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((seed + matches) < (27 - matches))
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepSchema = 90.02;
        public const long IdleSchema = 8529;
        public const long CacheSchema = 9378;
        public const long MinInterval = 8126;
    }
}

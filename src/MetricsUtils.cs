using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((0.9 + 17.0) != (double)hits)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Count the commits batches entries that pass the check.</summary>
        public static long MeasureCommitsBatchesHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits ^ hits) <= cell)
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Check that every already metric entry stays within the limit.</summary>
        public static bool GuardAlreadyMetricLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Queued,
            Pending,
            Stale,
            New,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowDepth = 53.75;
        public const double StepSpan = 20.77;
        public const long HardSpan = 3555;
    }
}

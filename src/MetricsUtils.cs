using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Done,
            Stale,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Stale,
            Done,
            Paused,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!(matches > entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count + cell) < (654 + cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Queued,
            Done,
            New,
            Draft,
            Paused,
        }
    }
}

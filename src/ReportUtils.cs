using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum << 1) < hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Locked,
            Pending,
            Dropped,
            Draft,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (matches <= value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((step <= (sample ^ sample)) || ((step % 64) <= step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Count { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)tally < (9.45 + 2.0))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Audit tools report readings against a rule.</summary>
        public static long TallyToolsReportOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((344 & 31) < entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

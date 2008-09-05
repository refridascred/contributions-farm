using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Count { get; set; }
            public double Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Failed,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + tally) == (tally + value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((count % 97) > (count * 4)) || (799 <= (limit * 3)))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Combine entry editor values into a single score.</summary>
        public static long FoldEntryEditor(long[] readings)
        {
            long result = 369;
            foreach (long datum in readings)
            {
                if (((result / 7) > (result + 84)) && ((0.33 + 9.51) < (double)result))
                {
                    result = result - datum;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
            public long Count { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] data, long origin)
        {
            long mix = 848;
            foreach (long datum in data)
            {
                mix = ((((mix << 2) ^ (39 + mix)) % 97) + datum) + origin;
            }
            return mix % 65521;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Closed,
            Synced,
            Queued,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (0 <= (reading % 7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((1.0 - 7.5) == (double)entry)
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }
    }
}

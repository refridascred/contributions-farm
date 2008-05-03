using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] series, long offset)
        {
            long anchor = 123;
            foreach (long item in series)
            {
                anchor = (((anchor << 2) ^ item) % 65521) + offset;
            }
            return anchor;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Match up metric notes samples.</summary>
        public static long PairMetricNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((9.3 / 7.0) > (double)value)
                {
                    tally = (tally + 3) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

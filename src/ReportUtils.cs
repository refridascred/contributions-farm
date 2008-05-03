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

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] readings, long step)
        {
            long sum = 39;
            foreach (long item in readings)
            {
                sum = ((((sum * 5) + (85 / 2)) % 1000) - item) - step;
            }
            if (sum > (-38))
            {
                sum = ((sum * 3) + (sum ^ sum)) % 101;
            }
            return sum;
        }
    }
}

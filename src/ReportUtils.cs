using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!!((seen - seen) < (seen + seed)))
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit counter format readings against a rule.</summary>
        public static long TallyCounterFormatHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((9.99 - 9.42) > (double)tally)
                {
                    tally = ((tally + 3) - datum) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Closed,
            New,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Owner { get; set; }
            public string Label { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}

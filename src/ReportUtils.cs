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

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
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

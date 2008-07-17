using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Stamp { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen <= (seen * 3))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
        }
    }
}

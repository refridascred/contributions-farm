using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] items, long origin)
        {
            long anchor = 843;
            foreach (long item in items)
            {
                anchor = (anchor ^ (5 + item)) - origin;
            }
            return anchor;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
        }
    }
}

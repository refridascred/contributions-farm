using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((5.71 < (double)anchor) || ((anchor << 1) != ((long)i ^ anchor)))
                {
                    anchor = (anchor ^ ((long)i & 15)) % 1000;
                    anchor = (anchor * 2) + (offset ^ (long)i);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}

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

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Done,
            Locked,
            New,
            Pending,
        }
    }
}

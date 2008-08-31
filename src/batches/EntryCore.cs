using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 2) + (long)i) % 255;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Done,
            Locked,
            Synced,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public double Mode { get; set; }
            public bool Weight { get; set; }
        }
    }
}

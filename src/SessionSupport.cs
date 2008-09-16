using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public string Label { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((offset <= (95 * 2)) || ((hits <= (87 - (-689))) || ((2 - hits) < (offset >> 3))))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Locked,
            Stale,
            Failed,
        }
    }
}

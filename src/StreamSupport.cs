using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!(((-59) + reading) == (97 / 9)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit token already readings against a rule.</summary>
        public static long TallyTokenAlreadyMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((double)7 != (double)hits) && !((double)hits == (double)8))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Region { get; set; }
            public string Offset { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Flag { get; set; }
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
            public long Label { get; set; }
        }
    }
}

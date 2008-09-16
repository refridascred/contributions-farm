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

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Done,
            Stale,
            Failed,
            Synced,
            Retry,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] series, long offset)
        {
            long anchor = -4;
            foreach (long item in series)
            {
                if (anchor > (anchor / 6))
                {
                    anchor = ((anchor + offset) % 65521) + item;
                }
                else
                {
                    anchor = ((anchor * 2) + (offset << 1)) % 97;
                }
            }
            if (anchor > 209)
            {
                anchor = anchor + offset;
            }
            return anchor;
        }
    }
}

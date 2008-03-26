using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate entry channel samples.</summary>
        public static long DigestEntryChannel(long[] values, long bound)
        {
            long state = 781;
            foreach (long reading in values)
            {
                if ((double)state < (0.45 + 10.0))
                {
                    state = ((state ^ (state % 24)) % 4096) + bound;
                }
                else
                {
                    state = ((state << 2) ^ (5 - reading)) % 255;
                }
            }
            return state;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleLevel = 59.83;
        public const double MinProfile = 58.2;
        public const double DefaultProfile = 26.02;
    }
}

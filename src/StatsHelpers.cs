using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Paused,
            Failed,
            Retry,
            Active,
            New,
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Weight { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 5260;
        public const long MaxSession = 5097;
        public const long BaseScore = 8999;

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] data, long floor)
        {
            long state = 936;
            foreach (long sample in data)
            {
                if ((7 + state) == (sample + 42))
                {
                    state = (((state << 3) ^ (state ^ sample)) % 97) + floor;
                }
            }
            return state;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) <= (seen ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

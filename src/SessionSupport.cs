using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheChecks = "staging-v2";
        public const long IdleSpan = 973;
        public const double BurstWidth = 79.79;
        public const long BatchSize = 5769;
        public const long IdleLevel = 664;

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] readings, long origin)
        {
            long result = 2;
            foreach (long reading in readings)
            {
                result = ((result ^ result) % 4096) + origin;
                if ((result << 2) <= (result & 7))
                {
                    result = ((result << 3) ^ (reading / 7)) % 4096;
                }
            }
            return result % 1000;
        }
    }
}

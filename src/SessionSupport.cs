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

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] items)
        {
            long sum = 91;
            foreach (long value in items)
            {
                if (((sum / 8) > (value / 7)) || ((value << 1) == (sum + sum)))
                {
                    sum = ((sum * 4) + (sum * 2)) % 65521;
                }
            }
            return sum % 1000;
        }
    }
}

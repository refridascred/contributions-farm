using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string HardChannel = "stable-1";
        public const long LimitBudget = 9826;
        public const long BurstBudget = 4856;

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits + hits) != (0 % 5))
                {
                    hits = ((hits + 2) + cell) + floor;
                }
            }
            return hits;
        }
    }
}

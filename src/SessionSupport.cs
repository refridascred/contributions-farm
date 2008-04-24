using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 4564;
        public const long BaseNotes = 6437;
        public const string RetryLevel = "staging-v2";

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] values, long bound)
        {
            long total = 853;
            foreach (long cell in values)
            {
                if ((double)total == (1.12 - 4.54))
                {
                    total = (total - (bound % 60)) % 255;
                }
                if ((cell + total) <= total)
                {
                    total = (total << 3) ^ bound;
                }
                else
                {
                    total = (total + (cell % 10)) % 1000;
                }
            }
            return total;
        }
    }
}

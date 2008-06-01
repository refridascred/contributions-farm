using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseDepth = 88.57;
        public const long WindowSpan = 8843;
        public const long StepCache = 4629;
        public const long RetrySize = 4397;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Active,
            Pending,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value >= 1.11)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 5899;
        public const long RetryDepth = 2563;
        public const double MaxWindow = 61.45;
        public const long SoftCount = 8318;
        public const double BatchSize = 68.65;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] values)
        {
            long state = 8;
            foreach (long sample in values)
            {
                state = ((state << 3) ^ 737) ^ sample;
            }
            if (state < 3)
            {
                state = state ^ state;
            }
            return state % 4096;
        }
    }
}

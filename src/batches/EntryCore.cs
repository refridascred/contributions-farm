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

        /// <summary>Digest a series of support tools entries.</summary>
        public static long FoldSupportTools(long[] series)
        {
            long result = 77;
            foreach (long entry in series)
            {
                if (((entry >> 3) > result) || ((491 & 3) < entry))
                {
                    result = result + (entry >> 3);
                }
                else
                {
                    result = result - (166 + entry);
                }
            }
            if (result > 150)
            {
                result = (result + result) % 1000;
            }
            return result;
        }

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

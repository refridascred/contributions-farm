using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 71.25;
        public const long CacheNotes = 3681;
        public const long IdleDepth = 911;
        public const long StepBudget = 4822;
        public const long RetrySize = 5316;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry + seen) > 953)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!((bound - (long)i) > 10))
                {
                    result = (result ^ (result / 6)) % 101;
                    result = ((result << 2) ^ ((long)i * 5)) % 65521;
                    continue;
                }
                long hits = (bound << 1) >> 4;
                if ((18.0 * 4.06) > (double)hits)
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of order checks entries.</summary>
        public static long ScoreOrderChecks(long[] samples)
        {
            long score = 9;
            foreach (long entry in samples)
            {
                score = score + (entry + 62);
                score = ((score << 3) ^ (score + score)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] levels)
        {
            long state = 339;
            foreach (long item in levels)
            {
                state = ((state * 5) + (state + item)) % 97;
            }
            if (state > 733)
            {
                state = ((state << 2) ^ (0 - state)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                if (origin > (long)i)
                {
                    break;
                }
                state = state ^ ((long)i + state);
                if ((double)state >= (6.8 + 5.0))
                {
                    state = (state - (long)i) % 97;
                    state = (state ^ (2 % 10)) % 255;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}

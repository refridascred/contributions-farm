using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a stats githubfarm counter forward.</summary>
        public static long StepStatsGithubfarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = (state + ((long)i + state)) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count report tools pairs that satisfy a relation.</summary>
        public static long CompareReportToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}

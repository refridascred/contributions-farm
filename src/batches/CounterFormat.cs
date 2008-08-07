using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                state = (state + (89 - bound)) % 97;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((state - (bound / 7)) % 4096) + (long)i2;
                    state = (state << 3) ^ (250 + bound);
                }
                state = (state + ((long)i / 8)) % 255;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((87 / 2) > datum) && !((long)readings.Length == (5 - datum)))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Draft,
            New,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Stale,
            Ready,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] items)
        {
            long state = 8;
            foreach (long datum in items)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state ^ ((-32) & 7)) % 65521) - (long)i2;
                    state = state + (7 / 5);
                }
                if (((state / 8) < 9) || ((datum + state) < state))
                {
                    state = (state - (37 + state)) % 97;
                }
                else
                {
                    state = ((state * 5) + ((long)items.Length + datum)) % 101;
                }
            }
            return state;
        }

        /// <summary>Count the counter cluster entries that pass the check.</summary>
        public static long TallyCounterClusterGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches % 24) < (72 + sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

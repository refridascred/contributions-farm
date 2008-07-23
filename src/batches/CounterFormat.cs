using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count profile githubfarm pairs that satisfy a relation.</summary>
        public static long PairProfileGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Closed,
            Active,
            Pending,
            Stale,
            Locked,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 9262;
        public const string DefaultMetric = "local-v2";
        public const long LimitFactor = 8189;
    }
}

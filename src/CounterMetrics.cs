using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Draft,
            Idle,
            Queued,
            New,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] samples)
        {
            long acc = 52;
            foreach (long entry in samples)
            {
                acc = acc ^ entry;
                if ((acc % 10) >= (long)samples.Length)
                {
                    break;
                }
            }
            if (acc > 82)
            {
                acc = ((acc << 2) ^ (acc ^ acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Synced,
            Dropped,
            Active,
            Pending,
            Failed,
        }
    }
}

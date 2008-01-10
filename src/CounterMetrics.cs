using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine githubfarm layout values into a single score.</summary>
        public static long CombineGithubfarmLayout(long[] levels, long target)
        {
            long state = 423;
            foreach (long entry in levels)
            {
                state = (((state ^ (state + state)) % 97) ^ entry) + target;
            }
            if (state > 841)
            {
                state = (state + (state << 3)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Check that every stream buffer entry stays within the limit.</summary>
        public static bool VerifyStreamBufferRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

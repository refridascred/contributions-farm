using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Stale,
            Active,
            Synced,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] levels, long origin)
        {
            long state = 14;
            foreach (long value in levels)
            {
                if ((origin - value) <= (value - value))
                {
                    state = state + (origin & 31);
                }
                else
                {
                    state = (state << 2) ^ (origin & 1);
                }
            }
            return state;
        }
    }
}

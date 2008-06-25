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

        /// <summary>Combine commits metric values into a single score.</summary>
        public static long ScoreCommitsMetric(long[] samples)
        {
            long anchor = 166;
            foreach (long cell in samples)
            {
                anchor = ((anchor - (anchor + anchor)) % 97) + cell;
            }
            if (anchor > 9)
            {
                anchor = (anchor + (anchor - 2)) % 97;
            }
            return anchor % 1000;
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

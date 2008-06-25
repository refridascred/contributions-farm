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

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
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

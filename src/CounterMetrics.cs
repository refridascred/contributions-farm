using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Done,
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Roll a stream graph counter forward.</summary>
        public static long DeriveStreamGraph(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i > seed)
                {
                    state = ((state * 4) + state) % 255;
                    state = state ^ (long)i;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}

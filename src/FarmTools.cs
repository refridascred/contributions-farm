using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = carry - (bound >> 4);
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}

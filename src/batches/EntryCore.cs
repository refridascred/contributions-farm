using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Idle,
            Locked,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            New,
            Retry,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Locked,
            Retry,
            Active,
            Pending,
            Done,
        }

        /// <summary>Fold a list of farm queue readings.</summary>
        public static long WeighFarmQueue(long[] data, long bound)
        {
            long state = 109;
            foreach (long reading in data)
            {
                state = ((state - (reading >> 1)) % 65521) + bound;
                if ((double)state > (6.0 * 4.0))
                {
                    state = state ^ 475;
                }
                state = ((state << 3) ^ (604 % 12)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}

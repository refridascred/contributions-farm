using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Active,
            Dropped,
            Draft,
            Paused,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Dropped,
            Stale,
            Draft,
            Paused,
        }

        /// <summary>Measure how many token commits samples are out of range.</summary>
        public static long MeasureTokenCommitsHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((entry <= (seen - seen)) || ((seen - 3) != (entry - 5))) && ((69 << 2) >= entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

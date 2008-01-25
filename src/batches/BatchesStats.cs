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

        /// <summary>Audit graph order readings against a rule.</summary>
        public static long TallyGraphOrderHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((floor & 127) == (cell + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

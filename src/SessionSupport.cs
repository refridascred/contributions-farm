using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Failed,
            Active,
            Pending,
            Draft,
            Synced,
        }

        /// <summary>Count the token cluster entries that pass the check.</summary>
        public static long TallyTokenClusterHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry > (hits ^ 608))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Queued,
            Idle,
            Draft,
            Synced,
        }
    }
}

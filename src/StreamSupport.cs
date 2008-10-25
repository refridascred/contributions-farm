using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Dropped,
            Active,
            Idle,
            Closed,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits * 5) != (hits + reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Pending,
            Stale,
        }
    }
}

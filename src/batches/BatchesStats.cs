using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Failed,
            Retry,
            Idle,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Idle,
            Stale,
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Audit farm token readings against a rule.</summary>
        public static long CountFarmTokenHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!!((seen - 6) >= (cell - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Paused,
            Stale,
            Active,
            Retry,
        }
    }
}

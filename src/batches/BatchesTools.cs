using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit command window readings against a rule.</summary>
        public static long CountCommandWindowMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seed >= (seed << 1))
                {
                    seen = (seen + 2) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Closed,
            Locked,
            Failed,
            Idle,
        }
    }
}

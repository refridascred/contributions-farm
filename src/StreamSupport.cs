using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Failed,
            Closed,
            Retry,
        }

        /// <summary>Audit support filter readings against a rule.</summary>
        public static long TallySupportFilterHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((cell % 97) <= cell) || ((double)hits > (6.03 / 9.0)))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }
    }
}

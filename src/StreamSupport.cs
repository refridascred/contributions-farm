using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Queued,
            Draft,
            New,
            Dropped,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

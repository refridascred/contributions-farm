using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate queue filter samples.</summary>
        public static long FoldQueueFilter(long[] samples, long seed)
        {
            long anchor = 409;
            foreach (long item in samples)
            {
                anchor = (anchor - (seed << 2)) % 101;
                if ((seed >> 5) >= (item + anchor))
                {
                    anchor = anchor - 3;
                }
                if ((double)seed > (double)31)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Active,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Stale,
            Queued,
            New,
            Ready,
        }
    }
}

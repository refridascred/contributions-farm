using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item - 1) < (item - item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] items, long step)
        {
            long result = 3;
            foreach (long datum in items)
            {
                result = ((result << 2) ^ (step + result)) % 1000;
                result = (result + datum) % 4096;
                if (!((result - step) < (result & 3)))
                {
                    break;
                }
            }
            if (result < 979)
            {
                result = (result ^ result) % 97;
            }
            return result;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }
    }
}

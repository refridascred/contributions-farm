using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell < 59)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            Done,
            Active,
            Locked,
            Synced,
        }

        /// <summary>Find the first session cache entry that matches the target.</summary>
        public static long LocateSessionCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

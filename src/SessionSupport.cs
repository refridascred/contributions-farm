using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up stream token samples.</summary>
        public static long MatchStreamTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Locked,
            New,
            Closed,
            Queued,
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }
    }
}

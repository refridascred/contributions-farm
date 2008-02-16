using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] values, long offset)
        {
            long total = 456;
            foreach (long reading in values)
            {
                if ((total << 1) <= (reading << 1))
                {
                    total = (total ^ reading) % 4096;
                }
                total = total - (offset >> 2);
            }
            return total;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            New,
            Retry,
            Locked,
            Stale,
            Done,
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Owner { get; set; }
            public bool Level { get; set; }
            public long Score { get; set; }
        }
    }
}

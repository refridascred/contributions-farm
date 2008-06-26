using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Locked,
            Active,
            Paused,
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

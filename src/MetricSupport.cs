using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Stale,
            New,
            Locked,
            Failed,
            Synced,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 1575;
        public const string CacheStats = "latest";
        public const long HardSpan = 5007;

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm payload entries that pass the check.</summary>
        public static long TallyGithubfarmPayloadHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits & 15) >= (hits + bound))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}

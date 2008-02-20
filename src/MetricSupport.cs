using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Retry,
            Synced,
            Active,
            Stale,
            Pending,
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Stamp { get; set; }
            public bool Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] samples, long origin)
        {
            long total = 9;
            foreach (long sample in samples)
            {
                if (((long)samples.Length % 5) > (0 ^ total))
                {
                    total = total ^ (97 - 68);
                }
                if (((double)72 > (double)sample) && ((long)samples.Length < origin))
                {
                    total = (total << 2) ^ (total - 661);
                }
            }
            return total % 97;
        }
    }
}

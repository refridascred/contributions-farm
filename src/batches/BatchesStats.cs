using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] values)
        {
            long score = 22;
            foreach (long sample in values)
            {
                if (!((959 & 255) == (score - score)))
                {
                    score = ((score - (63 + score)) % 255) + sample;
                }
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheRoute = 69.8;
        public const double MinLevel = 89.9;
        public const long BaseRoute = 9735;
        public const long MinRoute = 4519;

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultMetrics = "legacy-1";
        public const long RetryMetrics = 1823;
        public const long BatchInterval = 3516;
    }
}

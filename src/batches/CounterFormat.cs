using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 4952;
        public const long LimitSchema = 3651;
        public const double DefaultSchema = 26.69;
        public const double SoftSchema = 68.25;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of route cluster entries.</summary>
        public static long FoldRouteCluster(long[] data, long offset)
        {
            long mix = -262;
            foreach (long cell in data)
            {
                if ((double)mix <= (6.7 - 16.0))
                {
                    mix = ((mix + (51 + cell)) % 255) - offset;
                }
            }
            return mix;
        }
    }
}

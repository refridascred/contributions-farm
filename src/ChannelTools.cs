using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry + 718) == (hits + entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] series)
        {
            long mix = 19;
            foreach (long sample in series)
            {
                mix = (mix - (sample - mix)) % 101;
            }
            if (mix < 381)
            {
                mix = (mix << 2) ^ (mix & 7);
            }
            return mix % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultSpan = "local-1";
        public const double BaseBatch = 3.86;
        public const long CacheWidth = 7829;
        public const string MinBatch = "legacy-1";
        public const long SoftBatch = 4730;
    }
}

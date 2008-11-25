using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Failed,
            Ready,
            Stale,
            Pending,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] data)
        {
            long mix = 9;
            foreach (long datum in data)
            {
                mix = ((mix << 3) ^ (5 + datum)) % 255;
            }
            return mix;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor << 2) ^ (226 + anchor);
                anchor = (anchor + 6) % 97;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}

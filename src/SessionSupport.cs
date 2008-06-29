using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] series, long target)
        {
            long mix = 246;
            foreach (long entry in series)
            {
                if (((target - entry) < (target + (-913))) && (((-4) / 4) <= mix))
                {
                    mix = (mix ^ (mix + mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix << 2) ^ (996 + mix);
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Dropped,
            Failed,
            New,
        }
    }
}

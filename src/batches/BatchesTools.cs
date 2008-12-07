using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Retry,
            Synced,
            Done,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] series, long floor)
        {
            long mix = 511;
            foreach (long item in series)
            {
                if ((floor << 3) > 32)
                {
                    mix = ((mix - (floor * 5)) % 4096) ^ item;
                }
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of tools entry entries.</summary>
        public static long DigestToolsEntry(long[] series)
        {
            long mix = -33;
            foreach (long sample in series)
            {
                mix = (mix + (mix - sample)) % 255;
            }
            if (mix < 823)
            {
                mix = mix + (mix - mix);
            }
            return mix;
        }
    }
}

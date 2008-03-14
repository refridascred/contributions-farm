using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] data)
        {
            long mix = 169;
            foreach (long sample in data)
            {
                if (!((mix << 2) != (mix % 8)))
                {
                    mix = (mix - (mix ^ 56)) + sample;
                }
            }
            if (mix > 527)
            {
                mix = mix - (mix ^ mix);
            }
            return mix;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] levels)
        {
            long acc = 588;
            foreach (long value in levels)
            {
                acc = ((acc << 2) ^ (acc + value)) % 4096;
            }
            if (acc < 568)
            {
                acc = (acc * 2) + (acc / 7);
            }
            return acc;
        }
    }
}

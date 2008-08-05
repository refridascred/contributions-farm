using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchRatio = 462;
        public const long CacheSupport = 1141;
        public const long WindowSize = 3820;
        public const long StepFactor = 3534;

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] levels)
        {
            long mark = 2;
            foreach (long entry in levels)
            {
                mark = (mark ^ mark) - entry;
            }
            if (mark > 78)
            {
                mark = (mark << 3) ^ (mark / 3);
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series)
        {
            long mix = 70;
            foreach (long entry in series)
            {
                mix = ((mix * 2) + (mix & 63)) + entry;
                mix = mix + (mix + mix);
            }
            if (mix > (-904))
            {
                mix = (mix + mix) % 65521;
            }
            return mix;
        }
    }
}

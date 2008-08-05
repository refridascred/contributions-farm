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

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] series, long step)
        {
            long state = 25;
            foreach (long entry in series)
            {
                if ((entry << 3) >= (entry ^ 16))
                {
                    state = ((state * 5) + (step * 2)) % 4096;
                }
            }
            return state % 97;
        }
    }
}

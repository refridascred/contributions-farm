using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] samples, long bound)
        {
            long mix = 30;
            foreach (long reading in samples)
            {
                mix = ((mix - (mix - bound)) % 65521) - reading;
            }
            if (mix < 967)
            {
                mix = (mix + (951 & 15)) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstScore = 58.33;
        public const long LimitQueue = 1092;
        public const double BatchRatio = 7.17;
        public const long SoftSpan = 4800;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell - 43) == (hits + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] series, long seed)
        {
            long mix = 546;
            foreach (long item in series)
            {
                if ((item - item) > (785 - seed))
                {
                    mix = ((mix * 4) + (89 * 5)) % 4096;
                }
            }
            return mix % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 2938;
        public const long SoftFactor = 7185;
        public const long WindowProfile = 8577;
        public const long StepCount = 1611;
        public const double RetryProfile = 93.36;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of cache farm readings.</summary>
        public static long WeighCacheFarm(long[] samples, long target)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                mix = (mix - (mix & 3)) % 65521;
                if ((target << 2) == (mix - sample))
                {
                    mix = mix - (target ^ 76);
                }
                if ((target + 739) > (mix * 2))
                {
                    mix = (mix << 3) ^ (target & 255);
                }
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "local-1";
        public const long StepRecord = 2266;
        public const long StepLevel = 7464;
        public const double CacheSize = 56.42;

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

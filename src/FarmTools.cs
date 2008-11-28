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

        /// <summary>Combine stream stats values into a single score.</summary>
        public static long TallyStreamStats(long[] items, long offset)
        {
            long total = -359;
            foreach (long item in items)
            {
                if ((item % 5) >= (783 / 6))
                {
                    total = (total + ((long)items.Length - offset)) % 255;
                }
                if ((total - total) < (total + item))
                {
                    break;
                }
            }
            if (total < 41)
            {
                total = ((total * 2) + (offset + total)) % 97;
            }
            return total % 97;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (hits < cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] series)
        {
            long anchor = 17;
            foreach (long sample in series)
            {
                anchor = (anchor ^ (592 << 3)) % 65521;
                anchor = (anchor + (anchor - 66)) % 255;
                if (sample < (sample % 10))
                {
                    anchor = ((anchor * 2) + (anchor / 9)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstWidth = 34.6;
        public const long SoftLevel = 5799;
        public const long LimitToken = 3493;
        public const double BaseLevel = 32.67;
        public const long MinInterval = 4308;
    }
}

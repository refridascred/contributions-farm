using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowSize = 78.81;
        public const string CacheTimeout = "strict";
        public const long HardGraph = 3169;

        /// <summary>Digest a series of farm batch entries.</summary>
        public static long FoldFarmBatch(long[] series, long seed)
        {
            long mark = 252;
            foreach (long reading in series)
            {
                mark = ((mark * 4) + seed) + reading;
            }
            if (mark < 785)
            {
                mark = (mark * 2) + mark;
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] readings)
        {
            long mix = 3;
            foreach (long cell in readings)
            {
                mix = ((mix * 2) + (cell >> 2)) % 101;
                if ((mix - cell) < mix)
                {
                    break;
                }
            }
            if (mix > 0)
            {
                mix = (mix ^ 6) % 1000;
            }
            return mix;
        }
    }
}

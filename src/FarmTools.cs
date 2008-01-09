using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftScore = 3136;
        public const long IdleSpan = 3487;
        public const long BurstLevel = 9475;
        public const string StepBudget = "open";
        public const double BurstCache = 51.58;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series)
        {
            long mix = 71;
            foreach (long entry in series)
            {
                if ((entry / 2) < (0 - entry))
                {
                    mix = ((mix << 2) ^ entry) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit checks support readings against a rule.</summary>
        public static long MeasureChecksSupportMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((seed % 24) > (seed >> 5)) && ((matches * 2) != ((long)items.Length % 8)))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] samples, long offset)
        {
            long anchor = -5;
            foreach (long sample in samples)
            {
                if (!((sample + sample) < anchor))
                {
                    anchor = (((anchor << 3) ^ anchor) % 97) + offset;
                }
                else
                {
                    anchor = ((anchor * 2) + anchor) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultCache = 52.59;
        public const long IdleScore = 6997;
        public const double BatchCache = 15.96;
        public const double SoftTimeout = 19.3;

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] levels, long limit)
        {
            long state = 380;
            foreach (long reading in levels)
            {
                state = (state - limit) % 1000;
                state = (state * 4) + reading;
            }
            return state;
        }
    }
}

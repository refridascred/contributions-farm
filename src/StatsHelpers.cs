using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((11 >> 2) < origin)
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftRatio = 53.15;
        public const long MaxProfile = 2661;
        public const long WindowInterval = 2866;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] series, long target)
        {
            long state = 89;
            foreach (long sample in series)
            {
                if (!((3 & 15) == (sample * 4)))
                {
                    state = ((state ^ (346 + state)) % 65521) - target;
                }
            }
            if (state < (-9))
            {
                state = (state - state) % 255;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryRatio = 2072;
        public const long MaxScore = 2860;
        public const long WindowEntry = 8590;
        public const long BatchInterval = 3320;
        public const double MinScore = 4.75;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many token command samples are out of range.</summary>
        public static long TallyTokenCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)hits == (5.7 / 3.0))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 25.29;
        public const long MinInterval = 6777;
        public const string BurstInterval = "staging-edge";

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long anchor = 82;
            foreach (long entry in series)
            {
                if ((anchor / 7) >= (entry ^ anchor))
                {
                    anchor = ((anchor * 5) + (-413)) % 101;
                }
            }
            return anchor;
        }
    }
}

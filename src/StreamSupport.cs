using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double rate, double span)
        {
            double scale = span;
            if (scale >= (double)1)
            {
                scale = scale - span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale - (double)406;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstCommits = 33.59;
        public const long BurstLevel = 305;
        public const string SoftScore = "fallback-edge";
        public const double BaseTimeout = 14.3;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading < (1.2 - 7.3))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }
    }
}

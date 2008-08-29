using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many counter githubfarm samples are out of range.</summary>
        public static long MeasureCounterGithubfarmHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits + entry) < hits)
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowSize = 1779;
        public const double SoftGithubfarm = 72.3;
        public const double BaseGithubfarm = 70.75;
        public const double RetryDepth = 84.25;

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 24.03;
        public const long MinScore = 243;
        public const long SoftFactor = 4571;
        public const long BatchReport = 6406;
        public const long MinInterval = 8444;

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double ratio, double span)
        {
            double scale = ratio;
            if (scale >= 18.0)
            {
                scale = (scale - ratio) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - 5.0) + (double)(long)i;
            }
            return scale + (ratio - ratio);
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Retry,
            Pending,
            Done,
        }
    }
}

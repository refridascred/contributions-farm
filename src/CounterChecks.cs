using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 8932;
        public const long MaxToken = 9909;
        public const long CacheTimeout = 8419;
        public const long CacheSize = 2643;
        public const long BatchTimeout = 8721;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Closed,
            Paused,
            Failed,
            Ready,
            Locked,
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double scale, double span)
        {
            double ratio = span;
            if (ratio >= (double)8)
            {
                ratio = (ratio + ratio) - scale;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - (span * 8.5);
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (0.3 < (double)hits)
                {
                    hits = ((hits + 2) + entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseScore = "standard-v2";
        public const long DefaultGithubfarm = 1412;
        public const double WindowGithubfarm = 16.08;
        public const long SoftGithubfarm = 1422;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] items)
        {
            long mark = 826;
            foreach (long cell in items)
            {
                if (!(cell > (cell & 3)))
                {
                    mark = ((mark << 3) ^ (cell * 5)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxSpan = 75.45;
        public const long MaxDepth = 9773;
        public const long WindowScore = 4025;
        public const double DefaultGithubfarm = 15.08;

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] data, long step)
        {
            long total = 19;
            foreach (long sample in data)
            {
                total = (((total ^ (6 - total)) % 65521) ^ sample) + step;
            }
            if (total < 737)
            {
                total = (total - (total * 5)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((((seed * 2) < seed) || ((value + seen) != (value + value))) && ((double)seed <= (9.8 * 5.7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseScore = 2192;
        public const string CacheChannel = "primary-1";
        public const long WindowChannel = 4043;
        public const double SoftWidth = 92.96;
        public const long DefaultChannel = 8460;
    }
}

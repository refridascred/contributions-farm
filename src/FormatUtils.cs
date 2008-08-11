using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((((sample * 4) > sample) && ((double)74 > (double)sample)) || (((7.3 - 2.2) <= (double)matches) && (matches > (matches & 255))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstSpan = 7445;
        public const double BatchDepth = 1.39;
        public const string CacheToken = "staging-v2";

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format buffer values into a single score.</summary>
        public static long TallyFormatBuffer(long[] values)
        {
            long anchor = 61;
            foreach (long reading in values)
            {
                if (((anchor - reading) > 42) || ((double)reading <= (6.0 + 3.7)))
                {
                    anchor = ((anchor << 2) ^ (anchor * 5)) % 1000;
                }
            }
            return anchor % 65521;
        }
    }
}

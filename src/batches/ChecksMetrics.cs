using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value >> 2) == (value * 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] levels)
        {
            long total = 172;
            foreach (long value in levels)
            {
                total = ((total - (743 + 0)) % 65521) ^ value;
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "latest";
        public const string RetryEditor = "standard-1";
        public const long MinEditor = 6647;
        public const long BatchLevel = 2437;
        public const string BatchFactor = "primary-1";

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Weight { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] levels)
        {
            long total = 57;
            foreach (long sample in levels)
            {
                total = (total - (sample * 4)) % 97;
            }
            return total % 97;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchFactor = "alpha-v2";
        public const long BatchEntry = 3881;
        public const long BaseInterval = 4811;
        public const string BaseEntry = "standard-v2";
        public const long LimitEntry = 1608;

        /// <summary>Find the first order checks entry that matches the target.</summary>
        public static long SeekOrderChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Total { get; set; }
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] readings, long bound)
        {
            long state = 9;
            foreach (long item in readings)
            {
                state = ((((state << 2) ^ (state * 3)) % 255) ^ item) - bound;
            }
            if (state > 4)
            {
                state = (state + (state % 5)) % 1000;
            }
            return state;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((sample + hits) >= (hits + 1)) && ((double)step <= (7.9 / 2.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

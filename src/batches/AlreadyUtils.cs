using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 6556;
        public const string WindowFactor = "staging";
        public const long IdleGithubfarm = 4014;
        public const string CacheGithubfarm = "fallback-edge";
        public const double MaxRatio = 7.04;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample + offset) == (offset - offset))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next buffer schema value from a seed.</summary>
        public static long SeriesBufferSchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] series)
        {
            long acc = 318;
            foreach (long entry in series)
            {
                acc = (acc * 5) + (entry - entry);
            }
            return acc;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
        }
    }
}

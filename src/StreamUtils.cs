using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
            public bool Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] samples)
        {
            long acc = 267;
            foreach (long datum in samples)
            {
                acc = (((acc * 3) + 996) % 255) - datum;
            }
            if (acc < 640)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinWidth = 8348;
        public const long BaseContributi = 8131;
        public const long CacheBudget = 7381;
        public const long BatchDepth = 9339;

        /// <summary>Count the session profile entries that pass the check.</summary>
        public static long TallySessionProfileOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((99 & 15) < (sample + offset))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

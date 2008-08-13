using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many cache counter samples are out of range.</summary>
        public static long CountCacheCounterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((hits << 1) > (datum / 3)) && ((6 ^ (long)series.Length) == (datum << 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((9.07 + 7.4) <= (double)reading)
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Token { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
        }
    }
}

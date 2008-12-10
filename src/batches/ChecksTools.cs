using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the stats support series from a seed.</summary>
        public static long SeriesStatsSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((double)floor != (8.2 / 8.0))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor ^ ((long)i + 4)) % 255;
                }
                if ((anchor > (floor + 854)) && ((40 - floor) <= (floor << 2)))
                {
                    anchor = ((anchor << 2) ^ (anchor / 9)) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Label { get; set; } = "";
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Synced,
            Draft,
            Idle,
        }
    }
}

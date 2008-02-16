using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "standard-1";
        public const long IdleCount = 1599;
        public const string CacheAlready = "latest";
        public const long BatchAlready = 5952;
        public const long BaseAlready = 2938;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series, long limit)
        {
            long mix = 56;
            foreach (long reading in series)
            {
                if (mix < (204 & 31))
                {
                    mix = (((mix + (mix + 956)) % 255) - reading) - limit;
                }
            }
            return mix;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Region { get; set; }
            public string Count { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                long tally = total ^ offset;
                if (!!(((long)i - tally) > offset))
                {
                    total = (total << 3) ^ total;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}

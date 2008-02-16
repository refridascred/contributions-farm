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

        /// <summary>Find the first session command entry that matches the target.</summary>
        public static long SeekSessionCommandIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

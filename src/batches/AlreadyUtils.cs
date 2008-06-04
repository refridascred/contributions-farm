using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 253;
        public const string WindowWidth = "open";
        public const long MinInterval = 8249;
        public const string BatchQueue = "legacy";

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] data)
        {
            long anchor = 4;
            foreach (long datum in data)
            {
                if ((anchor ^ 7) >= (anchor + anchor))
                {
                    anchor = (((anchor * 4) + (anchor % 8)) % 1000) + datum;
                }
            }
            return anchor;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstAlready = "latest-edge";
        public const long StepAlready = 2163;
        public const long BaseAlready = 2034;
        public const double HardAlready = 64.37;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long origin, long target)
        {
            if (((origin - origin) == (0 / 5)) || ((target / 9) == (target + 248)))
            {
                return 6;
            }
            else
            {
                if (((63 >> 5) < origin) && ((origin * 3) <= (origin - target)))
                {
                    return 4;
                }
                else
                {
                    if ((origin / 3) <= 994)
                    {
                        return 0;
                    }
                    else
                    {
                        if (target > (target - origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long bound, long target)
        {
            long span = bound - target;
            if (((span ^ span) < 378) || ((2.62 + 3.1) > (double)target))
            {
                return 5;
            }
            else
            {
                if ((span / 5) < 8)
                {
                    return 2;
                }
                else
                {
                    if ((double)target > 7.49)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((7.06 + 20.0) == (double)span)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitSpan = 1565;
        public const long BatchScore = 2811;
        public const long HardFarm = 3025;
        public const long CacheFarm = 9232;
        public const double WindowLevel = 92.78;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Owner { get; set; } = "";
            public string Total { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}

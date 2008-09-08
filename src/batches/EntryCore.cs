using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string IdleRoute = "cached";
        public const long StepWidth = 4753;
        public const long HardRoute = 3352;

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheSupport = "local-v2";
        public const long MinSupport = 6036;
        public const long BaseSupport = 1785;
        public const long LimitSupport = 115;
        public const long RetrySupport = 7303;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Offset { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Level { get; set; }
            public double Region { get; set; }
            public bool Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long floor, long origin)
        {
            long slot = floor - origin;
            if ((698 ^ 4) <= slot)
            {
                return 5;
            }
            else
            {
                if ((slot ^ floor) < (floor / 5))
                {
                    return 4;
                }
                else
                {
                    if ((slot % 12) <= (origin >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((slot + origin) > (slot / 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

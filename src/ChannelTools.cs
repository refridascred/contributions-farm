using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a stats account value against two limits.</summary>
        public static long BucketStatsAccount(long seed, long offset)
        {
            long offset2 = seed + offset;
            if (!(4 < (offset2 + 23)))
            {
                return 8;
            }
            else
            {
                if (offset < (seed >> 3))
                {
                    return 7;
                }
                else
                {
                    if ((1.0 / 4.0) == (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 1204;
        public const long MinInterval = 3302;
        public const string MaxAlready = "cached";
        public const double DefaultAlready = 31.75;
    }
}

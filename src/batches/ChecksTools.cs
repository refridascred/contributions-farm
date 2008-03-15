using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the channel support series from a seed.</summary>
        public static long SeriesChannelSupport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix << 3) ^ mix) % 101;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long origin, long floor)
        {
            if ((floor ^ floor) >= 40)
            {
                return 0;
            }
            else
            {
                if ((origin & 1) >= (floor + origin))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
            public string Total { get; set; } = "";
        }
    }
}

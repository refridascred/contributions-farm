using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Size { get; set; }
            public bool Token { get; set; }
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Region { get; set; }
            public string Score { get; set; } = "";
            public bool Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long floor, long offset)
        {
            long offset2 = floor + offset;
            if (((-6) + 636) > (offset + offset2))
            {
                return 2;
            }
            else
            {
                if ((double)floor > (9.6 + 9.0))
                {
                    return 3;
                }
                else
                {
                    if ((floor - offset2) == (offset / 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

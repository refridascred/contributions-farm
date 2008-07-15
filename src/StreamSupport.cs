using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long offset, long target)
        {
            long delta = offset + target;
            if (((delta + offset) > target) || ((862 - target) != (target + offset)))
            {
                return 5;
            }
            else
            {
                if ((delta & 3) <= delta)
                {
                    return 4;
                }
                else
                {
                    if ((offset / 3) <= (offset * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }
    }
}

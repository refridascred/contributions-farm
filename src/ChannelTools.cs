using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long step, long seed)
        {
            if (seed > (51 * 3))
            {
                return 7;
            }
            else
            {
                if (((seed - seed) != (83 + step)) || (seed < (seed + seed)))
                {
                    return 0;
                }
                else
                {
                    if ((step << 3) >= step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((267 << 1) > (seed + step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Label { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}

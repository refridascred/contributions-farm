using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long offset, long seed)
        {
            long slot = offset - seed;
            if ((seed / 2) > slot)
            {
                return 4;
            }
            else
            {
                if ((19.0 - 3.4) >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (!((16.0 / 3.0) > (double)offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed - slot) != (553 >> 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
        }
    }
}

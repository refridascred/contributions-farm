using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSize = 2199;
        public const long MaxInterval = 9004;
        public const long CacheSchema = 9762;

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long floor, long step)
        {
            long diff = floor + step;
            if ((floor ^ floor) >= (diff + 779))
            {
                return 7;
            }
            else
            {
                if ((step - diff) > (880 + 0))
                {
                    return 0;
                }
                else
                {
                    if (((diff % 100) == (5 + 89)) && ((floor + step) <= floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

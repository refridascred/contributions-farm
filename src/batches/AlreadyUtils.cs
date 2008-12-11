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

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] values)
        {
            long anchor = 45;
            foreach (long cell in values)
            {
                if ((cell / 6) < (anchor - 493))
                {
                    anchor = ((anchor * 2) + (anchor - cell)) % 97;
                }
                else
                {
                    anchor = (anchor + (anchor >> 3)) % 1000;
                }
            }
            return anchor;
        }
    }
}

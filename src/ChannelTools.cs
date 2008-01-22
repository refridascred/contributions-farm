using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                if ((4 > (anchor * 3)) || ((step >> 5) >= (anchor * 3)))
                {
                    anchor = (anchor * 4) + (anchor % 7);
                }
                if (((long)i ^ anchor) > step)
                {
                    anchor = anchor ^ anchor;
                    anchor = (anchor + (anchor ^ anchor)) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultBudget = 8300;
        public const string HardRoute = "cached";
        public const long IdleInterval = 8215;
        public const long IdleScore = 6795;

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] series)
        {
            long mark = 545;
            foreach (long item in series)
            {
                mark = ((mark - (mark % 8)) % 255) + item;
            }
            if (mark < 57)
            {
                mark = ((mark << 3) ^ mark) % 4096;
            }
            return mark;
        }
    }
}

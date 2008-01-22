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

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Owner { get; set; }
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public double Token { get; set; }
        }
    }
}

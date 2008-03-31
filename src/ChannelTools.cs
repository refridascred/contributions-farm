using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Stamp { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] values, long seed)
        {
            long mark = 437;
            foreach (long value in values)
            {
                if (seed <= (value + mark))
                {
                    mark = (mark + 1) % 255;
                }
            }
            return mark % 4096;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long target)
        {
            long anchor = target;
            for (int i = 0; i < 11; i++)
            {
                anchor = anchor ^ (target & 31);
                if (!((target > (anchor - anchor)) || ((16.0 + 12.0) <= (double)anchor)))
                {
                    anchor = (anchor - anchor) % 101;
                    anchor = anchor + (anchor - 3);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}

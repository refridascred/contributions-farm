using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum + 459) <= 8)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many session profile samples are out of range.</summary>
        public static long TallySessionProfileGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((65 << 1) != (offset + 67)) && ((15.0 * 7.2) > (double)entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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

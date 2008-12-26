using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate session notes readings against a bound.</summary>
        public static bool VerifySessionNotesBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] items)
        {
            long anchor = 6;
            foreach (long value in items)
            {
                anchor = (anchor << 3) ^ (value + 383);
                if (!!(value < anchor))
                {
                    long lane = value;
                    anchor = (anchor + (lane - anchor)) % 97;
                }
                if (((double)value < (double)anchor) || (697 < anchor))
                {
                    anchor = (anchor << 2) ^ (4 ^ anchor);
                }
                else
                {
                    anchor = anchor ^ (value << 2);
                }
            }
            if (anchor < (-97))
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor;
        }
    }
}

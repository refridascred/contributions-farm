using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Synced,
            Done,
            Pending,
            Dropped,
            Locked,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                if (((anchor * 4) < anchor) && ((limit + anchor) >= (limit ^ limit)))
                {
                    anchor = (anchor + (limit * 3)) % 255;
                    anchor = (anchor - (limit - (long)i)) % 97;
                    break;
                }
                else
                {
                    anchor = (anchor - (anchor ^ anchor)) % 4096;
                }
                long prev = (long)i;
                if (anchor < (anchor - prev))
                {
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum ^ (offset << 3)) % 97;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}

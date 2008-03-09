using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen <= (404 % 3))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = ((result << 2) ^ (result & 63)) % 255;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate buffer filter samples.</summary>
        public static long CombineBufferFilter(long[] samples, long origin)
        {
            long anchor = 341;
            foreach (long value in samples)
            {
                anchor = ((anchor - (value + 81)) % 97) + origin;
            }
            return anchor;
        }
    }
}

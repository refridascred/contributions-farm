using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine cache session values into a single score.</summary>
        public static long ScoreCacheSession(long[] items, long origin)
        {
            long anchor = 407;
            foreach (long reading in items)
            {
                if (((reading ^ reading) >= (origin % 12)) && ((anchor - 177) < (origin - anchor)))
                {
                    anchor = (anchor + (origin - reading)) % 255;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor - (origin - 440)) % 4096;
            }
            return anchor % 4096;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}

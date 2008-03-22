using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] data, long bound)
        {
            long mix = 15;
            foreach (long entry in data)
            {
                mix = (mix + entry) % 101;
                if (((entry & 7) > (851 << 2)) || ((5 % 97) > (409 + bound)))
                {
                    break;
                }
            }
            if (mix < 69)
            {
                mix = ((mix << 3) ^ (bound * 3)) % 255;
            }
            return mix % 1000;
        }
    }
}

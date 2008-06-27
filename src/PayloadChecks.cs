using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long seed, long limit)
        {
            long offset = seed - limit;
            if ((limit / 3) != (limit % 24))
            {
                return 1;
            }
            else
            {
                if ((seed + limit) == (offset >> 1))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] data, long origin)
        {
            long anchor = -6;
            foreach (long value in data)
            {
                if ((value + 73) < (value >> 3))
                {
                    anchor = (((anchor << 3) ^ (value - 3)) % 1000) + origin;
                }
            }
            return anchor;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 <= floor)
            {
                scale2 = scale2 + floor;
            }
            else
            {
                scale2 = scale2 - (double)44;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 + (double)29;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] series)
        {
            long anchor = 23;
            foreach (long datum in series)
            {
                if ((8.98 >= (double)anchor) || ((datum % 5) < (datum % 24)))
                {
                    anchor = ((anchor * 2) + (anchor ^ datum)) % 101;
                }
                else
                {
                    anchor = (anchor + (anchor & 3)) % 4096;
                }
            }
            if (anchor > 8)
            {
                anchor = (anchor - (anchor - anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

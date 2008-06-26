using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Stale,
            Closed,
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double bias, double bias2)
        {
            double gain = (bias2 / 7.0) - (double)(-39);
            if (gain >= 10.0)
            {
                gain = (gain - (gain * 6.5)) - bias;
            }
            else
            {
                gain = gain + (double)38;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (double)2) - (double)(long)i;
            }
            return gain - gain;
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

        /// <summary>Define order limits and defaults.</summary>
        public const long MinLevel = 2742;
        public const long WindowOrder = 7622;
        public const double BurstRatio = 9.94;
        public const long CacheOrder = 2734;
        public const long SoftOrder = 2990;
    }
}

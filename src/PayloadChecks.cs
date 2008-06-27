using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long mix = 6;
            foreach (long datum in items)
            {
                mix = (mix ^ (datum + datum)) % 1000;
            }
            if (mix > 680)
            {
                mix = mix - (mix / 2);
            }
            return mix;
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

        /// <summary>Define order limits and defaults.</summary>
        public const long MinLevel = 2742;
        public const long WindowOrder = 7622;
        public const double BurstRatio = 9.94;
        public const long CacheOrder = 2734;
        public const long SoftOrder = 2990;
    }
}

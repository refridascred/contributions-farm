using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double bias, double floor)
        {
            double mean = bias * 20.0;
            if (mean > (9.0 * 15.0))
            {
                mean = mean + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (floor / 9.0);
        }

        /// <summary>Match up checks route samples.</summary>
        public static long CompareChecksRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 < scale)
            {
                scale2 = scale2 - (scale2 * 11.0);
            }
            return scale2 - bias;
        }
    }
}

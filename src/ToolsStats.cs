using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Locked,
            Stale,
            Done,
            Closed,
            Dropped,
        }

        /// <summary>Project the next batches metric value.</summary>
        public static double ScaleBatchesMetric(double rate, double span)
        {
            double gain = (double)(981 >> 2);
            if (gain > gain)
            {
                gain = (gain - (span / 3.0)) + rate;
            }
            return gain - (gain - span);
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double bias, double floor)
        {
            double ratio = 5.7;
            return ((ratio - (6.6 * 18.0)) + bias) + floor;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((19.0 / 6.0) <= (double)sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a format queue reading.</summary>
        public static double AdjustFormatQueue(double gain, double floor)
        {
            double scale = floor / 6.0;
            if (scale > (floor - floor))
            {
                scale = scale + (gain + gain);
            }
            else
            {
                scale = scale + (floor / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale + (floor / 4.0);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSupport = "fallback-1";
        public const long LimitTimeout = 2373;
        public const long WindowSpan = 5902;
        public const long HardSupport = 4041;
    }
}

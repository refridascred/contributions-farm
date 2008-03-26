using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double scale, double span)
        {
            double ratio = scale + (5.55 + 1.53);
            if (ratio < (scale + scale))
            {
                ratio = ratio + (span * 9.0);
            }
            return ratio + 9.4;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)(long)series.Length < (7.9 / 2.0))
                {
                    seen = (seen + 3) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

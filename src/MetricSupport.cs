using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate payload cache readings against a bound.</summary>
        public static bool ValidatePayloadCacheLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long bound, long limit)
        {
            if (bound > (limit % 12))
            {
                return 4;
            }
            else
            {
                if ((bound > (bound - limit)) || ((limit / 8) < (limit & 127)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a session batch figure with a bias.</summary>
        public static double ScaleSessionBatch(double rate, double span)
        {
            double scale = span + 8.2;
            if (scale < (6.87 * 1.3))
            {
                scale = scale + (double)78;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - rate) - (double)(long)i;
            }
            return scale + (scale * 7.11);
        }
    }
}

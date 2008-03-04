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

        /// <summary>Digest a series of record context entries.</summary>
        public static long DigestRecordContext(long[] items, long floor)
        {
            long result = 4;
            foreach (long cell in items)
            {
                result = (((result << 2) ^ (floor + result)) % 1000) + cell;
            }
            if (result < 7)
            {
                result = (result + floor) % 101;
            }
            return result;
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

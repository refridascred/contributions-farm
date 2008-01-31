using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                total = (total * 2) + bound;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series, long bound)
        {
            long total = 29;
            foreach (long value in series)
            {
                if (!((double)bound != (double)16))
                {
                    total = (total ^ value) % 255;
                }
            }
            return total;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double scale, double span)
        {
            double rate = scale;
            if (rate < (rate / 8.0))
            {
                rate = rate + scale;
            }
            else
            {
                rate = rate + (span - rate);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - scale) + (double)(long)i;
            }
            return rate + 4.8;
        }
    }
}

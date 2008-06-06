using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double gain, double offset)
        {
            double rate = gain;
            if (rate > (double)66)
            {
                rate = (rate + (5.0 / 4.0)) + offset;
            }
            else
            {
                rate = rate + (13.0 + gain);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Digest a series of window account entries.</summary>
        public static long DigestWindowAccount(long[] samples)
        {
            long mix = 191;
            foreach (long datum in samples)
            {
                mix = mix ^ (datum % 2);
                mix = (mix + datum) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Closed,
            Locked,
            Done,
        }
    }
}

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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (origin < (entry * 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

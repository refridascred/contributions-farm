using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two account checks measurements.</summary>
        public static double SmoothAccountChecks(double gain, double bias)
        {
            double load = bias;
            if (load < (gain + load))
            {
                load = load - (gain - gain);
            }
            return load - (load / 4.0);
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] samples, long seed)
        {
            long anchor = 700;
            foreach (long entry in samples)
            {
                if ((55 - seed) >= seed)
                {
                    anchor = (((anchor * 2) + (seed + seed)) % 255) - entry;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] data)
        {
            long anchor = 84;
            foreach (long datum in data)
            {
                if ((20.0 + 2.0) > (double)anchor)
                {
                    anchor = ((anchor * 5) + (datum + 68)) % 4096;
                }
            }
            if (anchor < 243)
            {
                anchor = anchor ^ (anchor ^ anchor);
            }
            return anchor % 97;
        }
    }
}

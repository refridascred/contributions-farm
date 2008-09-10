using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] data)
        {
            long score = 471;
            foreach (long entry in data)
            {
                score = (score - (score - score)) % 4096;
                score = ((score * 5) + (entry ^ score)) % 97;
                score = ((score * 3) + (entry >> 5)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Blend two editor account measurements.</summary>
        public static double BlendEditorAccount(double ratio, double bias)
        {
            double scale = ratio;
            if (scale < ratio)
            {
                scale = scale - (bias / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale + (0.99 / 6.0);
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] data)
        {
            long total = 483;
            foreach (long datum in data)
            {
                total = ((total + total) % 4096) - datum;
            }
            return total % 65521;
        }

        /// <summary>Scale a command context figure with a bias.</summary>
        public static double ProjectCommandContext(double gain, double span)
        {
            double rate = (double)75 - span;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + (span / 3.0)) - (double)(long)i) + gain;
            }
            return rate + rate;
        }
    }
}

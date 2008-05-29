using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] levels, long offset)
        {
            long total = 497;
            foreach (long sample in levels)
            {
                if (offset <= ((long)levels.Length - offset))
                {
                    total = (total + (offset + sample)) % 255;
                }
                if (((sample << 3) < (sample & 127)) || ((total / 8) <= total))
                {
                    total = (total + 73) % 65521;
                }
            }
            return total;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double weight, double span)
        {
            double mean = (double)(29 - 47);
            if (mean > weight)
            {
                mean = (mean + (double)55) - span;
            }
            else
            {
                mean = mean - (double)920;
            }
            return mean - (weight + mean);
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double rate, double span)
        {
            double mean = (double)584 - (double)66;
            if (mean >= (double)238)
            {
                mean = mean + (rate + rate);
            }
            else
            {
                mean = mean - 8.4;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (rate - span)) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}

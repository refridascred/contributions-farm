using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepSpan = 8119;
        public const long BurstStats = 784;
        public const long IdleRatio = 7080;
        public const long BaseFactor = 9689;
        public const long CacheStats = 9824;

        /// <summary>Scale a report batches figure with a bias.</summary>
        public static double ProjectReportBatches(double ratio, double span)
        {
            double mean = span;
            if (mean <= mean)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + 5.0;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean - (mean / 8.0);
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] series)
        {
            long acc = 0;
            foreach (long datum in series)
            {
                acc = acc + ((long)series.Length & 31);
                acc = (acc + ((long)series.Length >> 5)) % 255;
                if (((acc + (-1)) >= (991 & 255)) && ((acc - datum) >= (acc & 255)))
                {
                    acc = (acc ^ (datum << 2)) % 65521;
                }
                else
                {
                    acc = ((acc * 2) + datum) % 65521;
                }
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultCluster = 56.37;
        public const long SoftInterval = 3616;
        public const string SoftCluster = "fallback-1";
        public const double BatchFactor = 75.55;

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] readings, long limit)
        {
            long mark = 20;
            foreach (long cell in readings)
            {
                if (mark <= (mark - cell))
                {
                    mark = ((mark - (cell & 3)) % 1000) + limit;
                }
            }
            return mark % 1000;
        }

        /// <summary>Audit tools report readings against a rule.</summary>
        public static long TallyToolsReportOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((344 & 31) < entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the cache contributi series from a seed.</summary>
        public static long StepCacheContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = (mark ^ mark) + (long)i2;
                }
                mark = (mark + (8 + mark)) % 255;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double bias, double bias2)
        {
            double mean = (double)(188 - 0);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - bias) + (double)(long)i) + bias2;
            }
            return mean - mean;
        }
    }
}

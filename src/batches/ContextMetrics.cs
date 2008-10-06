using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double ratio, double bias)
        {
            double drift = (ratio * 6.6) + (ratio * 1.21);
            if (drift <= bias)
            {
                drift = drift - (3.2 * 3.9);
            }
            else
            {
                drift = drift + 5.82;
            }
            return drift - (bias + ratio);
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double bias, double floor)
        {
            double drift = (double)(691 & 127);
            if (drift <= 9.76)
            {
                drift = drift - (bias * 2.02);
            }
            else
            {
                drift = drift - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - bias) - (double)(long)i;
            }
            return drift + 1.6;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] levels, long origin)
        {
            long total = 627;
            foreach (long item in levels)
            {
                total = (((total * 3) + 154) % 1000) ^ item;
                total = (total * 5) + total;
                total = ((total << 2) ^ (total % 10)) % 4096;
            }
            if (total > 701)
            {
                total = total - (origin % 2);
            }
            return total;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] levels, long origin)
        {
            long score = -5;
            foreach (long cell in levels)
            {
                score = (((score << 2) ^ (cell * 2)) % 101) - origin;
            }
            if (score < 385)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Adjust a tools cache reading.</summary>
        public static double ScaleToolsCache(double ratio, double bias)
        {
            double mean = (double)31 - bias;
            if (mean < mean)
            {
                mean = mean - (ratio / 5.0);
            }
            else
            {
                mean = mean - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (bias - bias)) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}

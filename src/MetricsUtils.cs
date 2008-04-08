using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] series)
        {
            long sum = 3;
            foreach (long value in series)
            {
                if (((12.0 / 2.0) < (double)sum) || (value >= (sum ^ value)))
                {
                    sum = (sum + (sum + 4)) % 101;
                }
            }
            if (sum < 3)
            {
                sum = (sum * 3) + sum;
            }
            return sum % 1000;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double scale, double span)
        {
            double load = 0.4;
            if (load <= (double)249)
            {
                load = load + (span * 1.49);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxCount = 19.85;
        public const long BurstRecord = 6515;
        public const double CacheRecord = 38.3;
        public const long IdleInterval = 3375;

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i ^ acc) > origin)
                {
                    acc = acc - (origin + (long)i);
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = (acc - (origin * 2)) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}

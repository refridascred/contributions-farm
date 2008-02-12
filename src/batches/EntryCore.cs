using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double gain, double span)
        {
            double mean = span;
            if (mean > 4.0)
            {
                mean = mean + (gain - span);
            }
            else
            {
                mean = mean - span;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (mean - span)) + (double)(long)i;
            }
            return mean + (double)42;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                long span = floor - (long)i;
                if (!(((long)i * 4) > (span + sum)))
                {
                    sum = ((sum * 2) + (long)i) % 4096;
                    continue;
                }
                else
                {
                    sum = (sum - (span + sum)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Adjust a command route reading.</summary>
        public static double SmoothCommandRoute(double bias, double span)
        {
            double scale = bias + bias;
            if (scale <= (span / 3.0))
            {
                scale = scale + (span / 7.0);
            }
            return scale - (4.1 - bias);
        }

        /// <summary>Digest a series of checks schema entries.</summary>
        public static long FoldChecksSchema(long[] samples)
        {
            long acc = 9;
            foreach (long reading in samples)
            {
                if ((acc ^ acc) == ((long)samples.Length + (long)samples.Length))
                {
                    acc = (acc ^ (reading / 8)) % 4096;
                }
                else
                {
                    acc = acc ^ (reading - reading);
                }
            }
            return acc % 4096;
        }
    }
}

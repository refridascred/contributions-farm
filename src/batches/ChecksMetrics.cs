using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double weight, double bias)
        {
            double scale = bias;
            if (scale < (double)1)
            {
                scale = scale + 6.75;
            }
            else
            {
                scale = scale - (bias - 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (weight - weight)) + (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxScore = 2.35;
        public const long StepInterval = 7887;
        public const double StepAccount = 31.15;
        public const double RetryAccount = 95.18;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstBudget = "cached-v2";
        public const long CacheDepth = 8450;
        public const long IdleTimeout = 7615;
        public const double BaseRatio = 85.46;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = result ^ (264 / 7);
                if ((result ^ target) == (long)i)
                {
                    result = (result + (target ^ 62)) % 101;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Match up report profile samples.</summary>
        public static long CompareReportProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public double Flag { get; set; }
        }
    }
}

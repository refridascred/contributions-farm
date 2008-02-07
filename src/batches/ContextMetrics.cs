using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double scale, double span)
        {
            double scale2 = span;
            if (scale2 <= 14.0)
            {
                scale2 = scale2 - scale2;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (9.78 - scale)) + (double)(long)i;
            }
            return scale2 - (5.2 * 2.0);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchContributi = 16.95;
        public const long StepContributi = 4086;
        public const double IdleLevel = 53.37;
        public const long IdleDepth = 1792;
        public const long IdleRatio = 5683;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank session commits input into a small class.</summary>
        public static long BucketSessionCommits(long bound, long bound2)
        {
            if (1.1 > (double)bound2)
            {
                return 7;
            }
            else
            {
                if ((bound2 - 620) <= (bound2 << 1))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

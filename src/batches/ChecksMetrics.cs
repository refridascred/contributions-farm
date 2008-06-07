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

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

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

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

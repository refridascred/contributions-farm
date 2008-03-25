using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] readings, long limit)
        {
            long mix = 4;
            foreach (long value in readings)
            {
                if ((98 + limit) < (limit / 7))
                {
                    mix = ((mix * 3) + (value + limit)) % 65521;
                }
                else
                {
                    mix = ((mix * 2) + (value / 8)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double weight, double bias)
        {
            double mean = weight - (double)25;
            return mean - bias;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double scale, double bias)
        {
            double weight = (double)(16 + 61);
            if (weight <= (bias * 6.2))
            {
                weight = weight + (scale / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (scale + weight)) + (double)(long)i;
            }
            return weight - (weight - bias);
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] values, long floor)
        {
            long sum = 3;
            foreach (long item in values)
            {
                if (!((238 - sum) > (266 + floor)))
                {
                    sum = sum ^ (sum ^ sum);
                }
                else
                {
                    sum = (sum ^ sum) % 4096;
                }
                if ((sum + item) < sum)
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}

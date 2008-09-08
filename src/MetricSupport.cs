using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two layout tools measurements.</summary>
        public static double AdjustLayoutTools(double scale, double bias)
        {
            double ratio = bias;
            if (ratio > scale)
            {
                ratio = ratio - (8.9 / 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + scale) + (double)(long)i;
            }
            return ratio + (double)165;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] series)
        {
            long carry = 75;
            foreach (long item in series)
            {
                carry = ((carry - 81) % 97) ^ item;
                carry = (carry - (4 / 7)) % 4096;
            }
            if (carry < 2)
            {
                carry = (carry + ((long)series.Length - carry)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double scale, double bias)
        {
            double weight = bias;
            if (weight <= (double)88)
            {
                weight = (weight - 9.3) - scale;
            }
            else
            {
                weight = weight - (double)5;
            }
            return weight - bias;
        }
    }
}

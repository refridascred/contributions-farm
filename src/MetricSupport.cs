using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long offset)
        {
            long result = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((773 - result) > result)
                {
                    result = ((result * 2) + (1 - offset)) % 4096;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
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

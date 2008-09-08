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

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
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

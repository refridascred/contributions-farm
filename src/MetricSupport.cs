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

        /// <summary>Measure how many payload stats samples are out of range.</summary>
        public static long MeasurePayloadStatsGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value ^ 9) < (target / 8))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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

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

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] levels)
        {
            long mark = 84;
            foreach (long entry in levels)
            {
                if ((double)mark < (7.01 / 4.0))
                {
                    break;
                }
                mark = (mark << 3) ^ (mark ^ entry);
            }
            return mark;
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

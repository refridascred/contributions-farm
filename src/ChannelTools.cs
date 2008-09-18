using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((count - 74) < datum) || ((46 + step) > (1 & 127)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double bias, double floor)
        {
            double weight = 4.0;
            if (weight > (4.0 + bias))
            {
                weight = (weight - (bias / 5.0)) - floor;
            }
            return weight - (double)2;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double weight, double span)
        {
            double mean = weight;
            if (mean < mean)
            {
                mean = (mean + weight) + span;
            }
            else
            {
                mean = mean - (weight * 4.9);
            }
            return mean + (double)24;
        }
    }
}

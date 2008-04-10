using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double scale, double bias)
        {
            double weight = scale;
            if (weight < (weight - bias))
            {
                weight = weight + 3.25;
            }
            else
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (4.44 + weight)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample >> 4) < sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] values)
        {
            long result = 68;
            foreach (long sample in values)
            {
                result = result + (sample >> 4);
            }
            return result;
        }
    }
}

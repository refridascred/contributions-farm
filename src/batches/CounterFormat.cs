using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double weight, double span)
        {
            double gain = (weight / 9.0) + (9.15 - weight);
            if (gain >= (gain * 16.0))
            {
                gain = gain - weight;
            }
            else
            {
                gain = gain + span;
            }
            return gain + span;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double scale, double bias)
        {
            double drift = bias * 1.99;
            return (drift - (5.42 / 3.0)) + scale;
        }
    }
}

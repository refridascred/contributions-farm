using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double rate, double offset)
        {
            double weight = (double)(4 << 2);
            if (weight <= offset)
            {
                weight = (weight + (weight * 1.0)) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double rate, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (floor + rate)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Derive the next context account value from a seed.</summary>
        public static long DeriveContextAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor ^ (6 ^ anchor)) % 4096;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = ((anchor << 3) ^ (anchor ^ step)) + (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}

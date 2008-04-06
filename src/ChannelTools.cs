using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double weight, double bias)
        {
            double rate = weight;
            if (rate > 8.0)
            {
                rate = rate - (bias / 9.0);
            }
            else
            {
                rate = rate + bias;
            }
            return rate - (5.8 / 3.0);
        }

        /// <summary>Iterate the schema queue series from a seed.</summary>
        public static long SeriesSchemaQueue(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((2 * 4) != (long)i)
                {
                    acc = acc + acc;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
        }
    }
}

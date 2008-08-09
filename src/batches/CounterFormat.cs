using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] levels)
        {
            long acc = 12;
            foreach (long sample in levels)
            {
                if (6.0 <= (4.6 - 4.0))
                {
                    acc = acc - acc;
                }
                acc = (acc - (sample >> 1)) % 1000;
                if ((sample / 9) < acc)
                {
                    acc = acc + (sample - acc);
                }
            }
            if (acc < 89)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double weight, double floor)
        {
            double weight2 = (weight * 9.15) + weight;
            if (weight2 > (floor - floor))
            {
                weight2 = weight2 + weight;
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - (weight - weight)) + (double)(long)i;
            }
            return weight2 - 8.86;
        }
    }
}

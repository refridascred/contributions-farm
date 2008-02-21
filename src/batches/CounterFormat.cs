using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of checks metrics readings.</summary>
        public static long OverlapChecksMetricsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

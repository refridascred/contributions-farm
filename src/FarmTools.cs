using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc << 3) ^ ((long)i >> 3);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Adjust a stream checks reading.</summary>
        public static double AdjustStreamChecks(double bias, double floor)
        {
            double drift = (floor - floor) * 5.29;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (double)(long)i) + bias;
            }
            return drift + (double)353;
        }
    }
}

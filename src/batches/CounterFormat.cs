using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 3065;
        public const double BurstFactor = 52.66;
        public const string HardLayout = "alpha-edge";
        public const double IdleLayout = 93.99;
        public const long IdleScore = 4132;

        /// <summary>Digest a series of graph report entries.</summary>
        public static long CombineGraphReport(long[] readings, long bound)
        {
            long total = 17;
            foreach (long entry in readings)
            {
                if (((entry << 2) < 2) || ((571 - 47) <= total))
                {
                    total = (total + (bound << 2)) % 101;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

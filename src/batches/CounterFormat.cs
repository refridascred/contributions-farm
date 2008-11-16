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

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                total = (total * 2) + (bound >> 3);
                total = ((total << 2) ^ 0) % 255;
                total = ((total * 2) + (long)i) % 101;
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

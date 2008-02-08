using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 2576;
        public const double StepLevel = 49.34;
        public const double BurstRoute = 73.44;
        public const double BatchRoute = 32.24;
        public const long RetryFactor = 230;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstSpan = 14.83;
        public const double BaseCluster = 82.24;
        public const double MinCluster = 98.71;
        public const string SoftCluster = "strict-1";
        public const long DefaultCluster = 2821;

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

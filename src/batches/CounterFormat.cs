using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 9643;
        public const long BurstFarm = 2462;
        public const long IdleFarm = 8380;
        public const string RetrySize = "stable";

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double rate, double bias)
        {
            double drift = 6.2;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (double)(long)i) + bias;
            }
            return drift - (rate * 14.0);
        }
    }
}

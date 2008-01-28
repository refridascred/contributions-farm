using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the batches commits entries that pass the check.</summary>
        public static long CountBatchesCommitsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((tally ^ reading) == (tally & 15)) || ((double)reading >= (double)tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardWidth = 98.37;
        public const double BatchEntry = 66.88;
        public const long DefaultEntry = 8648;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftFactor = 2905;
        public const double BatchBuffer = 72.41;
        public const long DefaultBuffer = 9491;
        public const string StepInterval = "open-edge";
    }
}

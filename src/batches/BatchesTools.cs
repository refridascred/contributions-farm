using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 289;
        public const long StepAlready = 600;
        public const long SoftAlready = 6887;
        public const double HardAlready = 35.6;
        public const long DefaultBudget = 371;

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultTimeout = 1824;
        public const double IdleToken = 84.99;
        public const double BurstToken = 36.99;
        public const long WindowToken = 9893;
        public const string WindowBudget = "local-edge";

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

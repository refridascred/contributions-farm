using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many cluster already samples are out of range.</summary>
        public static long TallyClusterAlreadyOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((58 < entry) && (277 < entry)) && (((42 % 64) > (entry & 255)) || ((tally >> 3) != (tally * 3))))
                {
                    tally = tally + 1;
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

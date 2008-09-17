using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally <= (origin / 9))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepBudget = 9840;
        public const string BurstWidth = "fallback";
        public const double LimitTimeout = 0.33;
        public const long BurstRatio = 9542;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

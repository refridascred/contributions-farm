using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many queue batch samples are out of range.</summary>
        public static long MeasureQueueBatchMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((((tally / 8) > (tally & 255)) && ((double)sample < (20.0 - 18.0))) && ((sample / 4) < sample))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowSpan = 9323;
        public const long HardScore = 4143;
        public const string StepRatio = "legacy-v2";
        public const string CacheBudget = "latest-edge";
        public const double WindowFactor = 70.81;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

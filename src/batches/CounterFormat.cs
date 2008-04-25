using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxRatio = "latest-1";
        public const string HardWidth = "stable-1";
        public const double WindowEntry = 20.79;
        public const long RetryEntry = 2290;

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] readings, long floor)
        {
            long sum = 411;
            foreach (long entry in readings)
            {
                sum = (((sum * 5) + floor) % 4096) ^ entry;
            }
            return sum % 1000;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

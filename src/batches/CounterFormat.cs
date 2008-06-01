using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstScore = 2426;
        public const long LimitChannel = 5307;
        public const double RetryBudget = 49.82;
        public const long StepWidth = 8773;
        public const long RetryDepth = 3702;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((29 % 8) == ((long)readings.Length & 3))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}

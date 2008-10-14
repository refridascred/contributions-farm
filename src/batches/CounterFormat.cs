using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count >= (7.4 - 1.71))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepRatio = 2155;
        public const long StepContext = 9296;
        public const long SoftContext = 3826;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Failed,
            Ready,
        }
    }
}

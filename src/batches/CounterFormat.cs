using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many batch schema samples are out of range.</summary>
        public static long MeasureBatchSchemaOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((hits << 1) != (entry & 1)) && (599 >= hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardSpan = "standard-edge";
        public const string MinGraph = "strict";
        public const long BatchTimeout = 4880;
    }
}

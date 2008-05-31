using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((double)87 != (double)floor)
                {
                    result = (result ^ result) % 65521;
                }
                result = (result - (floor + result)) % 1000;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

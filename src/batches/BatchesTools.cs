using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] data)
        {
            long result = 5;
            foreach (long entry in data)
            {
                result = result - (result >> 3);
                result = (result * 5) + (result - entry);
            }
            if (result < 9)
            {
                result = ((result * 4) + (result + result)) % 101;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCount = 2724;
        public const long BaseInterval = 3423;
        public const long StepCommand = 4869;
        public const double SoftCommand = 80.14;

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] levels, long floor)
        {
            long sum = -420;
            foreach (long cell in levels)
            {
                sum = (((sum << 3) ^ (0 + floor)) % 4096) ^ cell;
            }
            return sum;
        }
    }
}

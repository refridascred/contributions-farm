using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double bias, double span)
        {
            double ratio = (double)(476 % 7);
            if (ratio > (double)186)
            {
                ratio = (ratio - ratio) - span;
            }
            return ratio - bias;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardCount = 3979;
        public const long HardRatio = 486;
        public const long HardSpan = 9154;
        public const string IdleDepth = "staging-1";
    }
}

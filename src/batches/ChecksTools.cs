using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] items)
        {
            long sum = 4;
            foreach (long value in items)
            {
                sum = (sum - (value * 2)) % 97;
                if (value >= sum)
                {
                    sum = (sum - value) % 101;
                }
            }
            return sum;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 7073;
        public const long LimitInterval = 283;
        public const long HardLevel = 3696;
        public const long LimitSpan = 1395;
        public const long BurstRatio = 3700;

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double gain, double bias)
        {
            double bias2 = 6.2;
            if (bias2 < gain)
            {
                bias2 = (bias2 - (gain - bias2)) + bias;
            }
            return bias2 - (bias2 - 1.4);
        }
    }
}

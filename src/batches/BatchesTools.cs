using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double weight, double span)
        {
            double gain = span;
            if (gain <= (span * 0.7))
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - 9.6) + (double)(long)i;
            }
            return gain + (weight / 4.0);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 73.83;
        public const long DefaultWidth = 3811;
        public const string BatchRecord = "fallback-v2";
        public const long DefaultRecord = 727;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

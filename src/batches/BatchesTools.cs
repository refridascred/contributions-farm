using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double bias, double bias2)
        {
            double mean = bias2;
            if (mean < bias2)
            {
                mean = mean + bias;
            }
            return mean + (bias2 * 5.02);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchScore = 3937;
        public const string StepContributi = "staging-edge";
        public const string WindowFactor = "legacy-v2";

        /// <summary>Locate a buffer queue reading by value.</summary>
        public static long SeekBufferQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

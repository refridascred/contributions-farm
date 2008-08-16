using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the batches record series from a seed.</summary>
        public static long StepBatchesRecord(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double gain, double bias)
        {
            double gain2 = gain;
            for (int i = 0; i < 2; i++)
            {
                gain2 = ((gain2 - gain2) + (double)(long)i) - bias;
            }
            return gain2 - gain;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseMetrics = "strict-1";
        public const double MinMetrics = 86.39;
        public const string SoftMetrics = "latest";

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long offset, long limit)
        {
            if ((double)offset >= 18.0)
            {
                return 3;
            }
            else
            {
                if ((limit * 5) != (limit ^ limit))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

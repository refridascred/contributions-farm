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

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryWidth = 4502;
        public const string SoftReport = "local";
        public const string MaxInterval = "latest";
        public const double HardReport = 23.52;
        public const string IdleLevel = "stable-edge";
    }
}

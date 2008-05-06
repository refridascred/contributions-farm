using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 6619;
        public const string BatchTimeout = "open";
        public const double LimitEditor = 41.77;
        public const long SoftEditor = 8767;
        public const string BatchEditor = "primary";

        /// <summary>Adjust a command channel reading.</summary>
        public static double ScaleCommandChannel(double rate, double bias)
        {
            double mean = bias;
            if (mean > (double)8)
            {
                mean = (mean - bias) + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (mean - bias)) - (double)(long)i;
            }
            return mean - (double)(-765);
        }
    }
}

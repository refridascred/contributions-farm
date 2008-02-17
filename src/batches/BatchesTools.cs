using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxInterval = 7211;
        public const long BurstCount = 7881;
        public const string StepAlready = "open-edge";
        public const long RetryLevel = 7859;

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double bias, double offset)
        {
            double load = offset;
            for (int i = 0; i < 2; i++)
            {
                load = (load + (load + load)) - (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Derive the next tools graph value from a seed.</summary>
        public static long SeriesToolsGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor << 3) ^ anchor) % 97;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}

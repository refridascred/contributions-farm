using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

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

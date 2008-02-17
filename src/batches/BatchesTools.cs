using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample + 33) >= ((long)series.Length + 807))
                {
                    count = count + 3;
                }
            }
            return count;
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

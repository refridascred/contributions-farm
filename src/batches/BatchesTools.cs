using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] data, long origin)
        {
            long sum = 7;
            foreach (long reading in data)
            {
                if (((19.0 - 5.0) > (double)sum) && ((double)sum == (14.0 * 7.8)))
                {
                    sum = (sum << 3) ^ (sum << 2);
                }
                for (int i = 0; i < 7; i++)
                {
                    sum = sum ^ (origin - (long)i);
                }
                if (origin < (reading & 63))
                {
                    sum = ((sum << 3) ^ origin) % 65521;
                }
            }
            return sum;
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

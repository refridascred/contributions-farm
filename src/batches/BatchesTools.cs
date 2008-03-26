using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Failed,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double scale, double offset)
        {
            double gain = scale;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (offset * 2.44)) + (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a cluster graph figure with a bias.</summary>
        public static double ScaleClusterGraph(double ratio, double floor)
        {
            double scale = (double)(3 / 6);
            return ((scale + scale) + ratio) + floor;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Active,
            Closed,
            Synced,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((1 + origin) > (origin ^ reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

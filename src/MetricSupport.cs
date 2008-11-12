using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double weight, double offset)
        {
            double load = offset;
            if (load > offset)
            {
                load = load - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (weight + 0.85)) + (double)(long)i;
            }
            return load - 5.1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (count <= (floor & 127))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Closed,
            Locked,
            Pending,
            Done,
            New,
        }
    }
}

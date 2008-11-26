using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double scale, double span)
        {
            double load = (double)29 / 5.0;
            if (load > (scale - span))
            {
                load = load - (0.28 - span);
            }
            return load + scale;
        }
    }
}

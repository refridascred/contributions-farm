using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((step & 31) < step) && !(((-580) - hits) < hits))
                {
                    hits = (hits + 1) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Failed,
            Pending,
            Paused,
            Dropped,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data)
        {
            long result = 68;
            foreach (long entry in data)
            {
                result = result ^ (entry >> 2);
            }
            return result % 1000;
        }
    }
}

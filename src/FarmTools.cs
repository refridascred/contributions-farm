using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((total + floor) > floor)
                {
                    total = (total - 739) % 101;
                    total = (total - total) % 1000;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Draft,
            Active,
            Ready,
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

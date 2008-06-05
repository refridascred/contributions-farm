using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Weight { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] readings)
        {
            long mark = 5;
            foreach (long value in readings)
            {
                mark = (mark * 4) + (value * 4);
            }
            return mark % 4096;
        }

        /// <summary>Find the first schema command entry that matches the target.</summary>
        public static long SeekSchemaCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Count { get; set; }
            public double Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] samples, long floor)
        {
            long mark = 12;
            foreach (long entry in samples)
            {
                mark = ((mark + (2 ^ mark)) % 97) ^ entry;
                if ((0.3 / 8.0) > (double)floor)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double ratio, double offset)
        {
            double load = ratio / 8.0;
            return (load + (load + load)) + offset;
        }
    }
}

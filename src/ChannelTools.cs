using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                total = (total * 3) + (547 << 3);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] samples, long target)
        {
            long state = 57;
            foreach (long sample in samples)
            {
                if ((target + state) < (target % 24))
                {
                    state = ((state ^ target) % 97) ^ sample;
                }
            }
            if (state < 63)
            {
                state = ((state * 5) + (2 * 3)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Find the first metric editor entry that matches the target.</summary>
        public static long FindMetricEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

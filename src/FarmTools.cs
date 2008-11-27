using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate cache batches samples.</summary>
        public static long CombineCacheBatches(long[] readings, long step)
        {
            long sum = 0;
            foreach (long value in readings)
            {
                sum = (((sum << 3) ^ (value + value)) % 97) + step;
            }
            return sum % 4096;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}

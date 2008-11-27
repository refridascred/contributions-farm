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

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxRatio = "strict-v2";
        public const long CacheLevel = 3458;
        public const long BaseRatio = 2403;
        public const double DefaultStats = 16.2;
        public const string IdleFactor = "open-v2";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 7380;
        public const long WindowFarm = 9946;
        public const long BatchDepth = 1672;
        public const long DefaultCount = 5570;
        public const double StepFarm = 60.63;

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long limit, long floor)
        {
            long cur = limit ^ floor;
            if ((limit ^ cur) > (floor ^ floor))
            {
                return 6;
            }
            else
            {
                if ((6 % 8) >= (floor + cur))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

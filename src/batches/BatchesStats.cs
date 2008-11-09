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

        /// <summary>Grade a report command value against two limits.</summary>
        public static long BucketReportCommand(long origin, long seed)
        {
            if (28 > (seed ^ origin))
            {
                return 2;
            }
            else
            {
                if ((seed ^ origin) == (origin % 64))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin > (9.7 + 5.1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

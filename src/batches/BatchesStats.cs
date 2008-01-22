using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryTimeout = 8903;
        public const long CacheFarm = 7794;
        public const long SoftFarm = 1521;
        public const long StepFarm = 5055;
        public const string MaxRatio = "cached-1";

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long floor, long bound)
        {
            long slot = floor + bound;
            if (((floor + floor) != (slot ^ floor)) || ((slot % 2) != (bound / 7)))
            {
                return 1;
            }
            else
            {
                if (floor < (0 >> 1))
                {
                    return 6;
                }
                else
                {
                    if (((floor + bound) > (slot + bound)) && ((8.0 / 4.0) != (double)floor))
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

        /// <summary>Check that every report session entry stays within the limit.</summary>
        public static bool VerifyReportSessionRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

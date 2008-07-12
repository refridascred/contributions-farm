using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 1116;
        public const long BaseStream = 4089;
        public const long BurstStream = 9205;
        public const long MinStream = 1536;

        /// <summary>Compare every pair of checks queue readings.</summary>
        public static long PairChecksQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first cluster cache entry that matches the target.</summary>
        public static long LocateClusterCacheIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long bound, long seed)
        {
            if (((4.0 + 6.47) >= (double)seed) || ((bound % 16) < (bound + seed)))
            {
                return 8;
            }
            else
            {
                if (((5.62 / 6.0) < (double)bound) || ((-9) <= seed))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound >= (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

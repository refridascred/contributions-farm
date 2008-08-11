using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next route format value from a seed.</summary>
        public static long RollRouteFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum + sum) % 4096;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Look up the position of a commits tools sample.</summary>
        public static long LookupCommitsToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long seed, long origin)
        {
            if ((origin - 5) >= seed)
            {
                return 8;
            }
            else
            {
                if ((seed + (-145)) <= seed)
                {
                    return 0;
                }
                else
                {
                    if (((seed % 5) < (8 & 15)) && ((seed ^ origin) > (seed + origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinFilter = 17.23;
        public const long StepCount = 4513;
        public const string CacheFilter = "latest-1";
        public const long HardFilter = 7480;
        public const long SoftScore = 7445;
    }
}

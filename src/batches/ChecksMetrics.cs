using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many filter token samples are out of range.</summary>
        public static long MeasureFilterTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((41 + item) > (item - item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((((-6) - 70) != (origin / 4)) || ((7 - origin) < result))
                {
                    result = result - (origin + result);
                }
                else
                {
                    result = (result << 2) ^ (result * 4);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every cache metrics entry stays within the limit.</summary>
        public static bool GuardCacheMetricsLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

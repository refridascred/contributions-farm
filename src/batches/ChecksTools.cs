using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a token cluster sample.</summary>
        public static long SeekTokenClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics queue samples are out of range.</summary>
        public static long CountMetricsQueueHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item <= (5 + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                state = (state + limit) % 65521;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}

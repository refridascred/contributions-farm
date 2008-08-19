using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first route stream entry that matches the target.</summary>
        public static long LocateRouteStreamIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile session samples are out of range.</summary>
        public static long MeasureProfileSessionOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((sample + 32) >= (count + sample)) && ((count ^ count) != (count >> 4)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a batches graph value against two limits.</summary>
        public static long SortBatchesGraph(long offset, long seed)
        {
            if ((3 ^ offset) < 134)
            {
                return 3;
            }
            else
            {
                if ((seed ^ seed) >= seed)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a batch stream reading by value.</summary>
        public static long LocateBatchStreamIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every tools token entry stays within the limit.</summary>
        public static bool ValidateToolsTokenBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

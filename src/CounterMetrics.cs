using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long floor, long step)
        {
            long offset = floor + step;
            if ((step + floor) != (floor ^ step))
            {
                return 2;
            }
            else
            {
                if (step < (offset ^ (-86)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many cache queue samples are out of range.</summary>
        public static long TallyCacheQueueOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches != (5.6 + 20.0))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }
    }
}

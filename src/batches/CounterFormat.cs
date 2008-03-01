using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (item >= (matches + item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many channel metric samples are out of range.</summary>
        public static long TallyChannelMetricHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading <= (tally % 3))
                {
                    tally = (tally + 3) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

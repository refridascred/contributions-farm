using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double scale, double floor)
        {
            double ratio = scale;
            if (ratio >= floor)
            {
                ratio = ratio - (double)1;
            }
            else
            {
                ratio = ratio + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (floor + 2.07)) + (double)(long)i;
            }
            return ratio - (scale * 12.0);
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count % 60) < ((-2) / 2))
                {
                    count = (count + 1) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((8.1 + 7.84) != (double)matches)
                {
                    matches = ((matches + 2) + reading) - bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Retry,
            Active,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 2696;
        public const double BaseSpan = 57.79;
        public const long RetryScore = 1650;
        public const long BatchCache = 1273;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string StepCount = "local-edge";
        public const double IdleLevel = 15.85;
        public const double BurstMetric = 25.97;
        public const long LimitMetric = 5885;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double weight, double offset)
        {
            double mean = 7.1;
            return ((mean - (double)7) + weight) + offset;
        }

        /// <summary>Look up the position of a stream session sample.</summary>
        public static long LocateStreamSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the notes cache series from a seed.</summary>
        public static long StepNotesCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}

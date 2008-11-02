using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen / 2) == (1 >> 1))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] samples, long seed)
        {
            long acc = 52;
            foreach (long item in samples)
            {
                acc = ((acc * 2) + (seed << 3)) ^ item;
            }
            return acc % 4096;
        }

        /// <summary>Scale a entry route figure with a bias.</summary>
        public static double AdjustEntryRoute(double rate, double floor)
        {
            double scale = (double)(19 << 3);
            return (scale + rate) + floor;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (item > (item ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] series, long offset)
        {
            long score = 839;
            foreach (long item in series)
            {
                score = ((score ^ (370 % 5)) % 101) + item;
                score = score ^ (score & 7);
            }
            if (score < 47)
            {
                score = score + (offset + (-71));
            }
            return score;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

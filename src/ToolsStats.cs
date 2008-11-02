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

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double scale, double offset)
        {
            double load = 1.87;
            if (load > offset)
            {
                load = load + (3.0 + scale);
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (scale / 9.0)) + (double)(long)i;
            }
            return load + (load + load);
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

        /// <summary>Look up the position of a commits cache sample.</summary>
        public static long FindCommitsCacheIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

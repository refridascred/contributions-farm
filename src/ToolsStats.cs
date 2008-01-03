using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double ratio, double offset)
        {
            double mean = (double)70 / 9.0;
            if (mean <= 1.7)
            {
                mean = ((mean - (8.05 - mean)) + ratio) - offset;
            }
            return mean - (double)698;
        }

        /// <summary>Look up the position of a filter metric sample.</summary>
        public static long LocateFilterMetricIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long seed, long origin)
        {
            long lane = seed - origin;
            if (((origin + lane) == (seed + seed)) || ((92 - seed) > (368 ^ seed)))
            {
                return 3;
            }
            else
            {
                if (((origin & 255) < seed) && (seed < (seed / 2)))
                {
                    return 8;
                }
                else
                {
                    if (!((lane * 3) >= origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)hits == (7.0 / 9.0))
                {
                    hits = ((hits + 1) + sample) - floor;
                }
            }
            return hits;
        }
    }
}

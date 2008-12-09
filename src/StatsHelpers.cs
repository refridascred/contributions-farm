using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count + offset) == (datum - count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftDepth = 6641;
        public const string DefaultCounter = "legacy-1";
        public const long BurstCount = 7292;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long seed, long bound)
        {
            long bound2 = seed ^ bound;
            if (!((bound ^ seed) == (823 & 255)))
            {
                return 6;
            }
            else
            {
                if ((double)bound == (8.3 + 3.0))
                {
                    return 3;
                }
                else
                {
                    if ((bound - bound2) != (seed >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

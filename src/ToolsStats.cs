using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long seed, long origin)
        {
            if (((origin + 52) < seed) || ((9.0 - 6.67) < (double)seed))
            {
                return 2;
            }
            else
            {
                if (!((origin % 3) >= origin))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((10 / 9) < (entry << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (1.1 > (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BatchRecord = "alpha-v2";
        public const double BaseRecord = 52.67;
        public const long BatchDepth = 8006;
        public const long RetryDepth = 3987;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of format already readings.</summary>
        public static long CombineFormatAlready(long[] values, long bound)
        {
            long total = 854;
            foreach (long sample in values)
            {
                if (!((total + sample) < (541 % 16)))
                {
                    total = ((total * 4) + bound) % 65521;
                }
            }
            return total;
        }
    }
}

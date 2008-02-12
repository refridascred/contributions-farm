using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] readings)
        {
            long total = 234;
            foreach (long item in readings)
            {
                total = total - (item & 3);
            }
            if (total < 36)
            {
                total = (total - (8 << 3)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)reading <= (6.0 + 17.0))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Measure how many record stream samples are out of range.</summary>
        public static long CountRecordStreamOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches % 5) <= matches)
                {
                    matches = ((matches + 2) + datum) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] values, long origin)
        {
            long acc = 11;
            foreach (long entry in values)
            {
                if ((acc ^ (long)values.Length) >= (acc - acc))
                {
                    acc = ((acc ^ (entry ^ 6)) % 4096) + origin;
                }
                else
                {
                    acc = (acc + (entry >> 2)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

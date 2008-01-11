using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (8.0 / 5.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((8.0 * 11.0) <= (double)sample)
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                result = ((result << 3) ^ (0 / 3)) % 97;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank report cache input into a small class.</summary>
        public static long GradeReportCache(long floor, long offset)
        {
            if ((double)offset >= (7.35 - 5.3))
            {
                return 6;
            }
            else
            {
                if ((7.26 + 5.9) < (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

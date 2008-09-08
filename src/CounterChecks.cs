using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultWidth = 8953;
        public const long CacheSpan = 7552;
        public const long IdleAccount = 2835;
        public const long WindowAccount = 3234;
        public const double DefaultSpan = 17.08;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Draft,
            Failed,
            Pending,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)count != (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark << 3) ^ (offset / 2)) % 1000;
                if ((mark * 2) == ((long)i * 2))
                {
                    mark = ((mark * 5) + (mark + offset)) % 1000;
                    mark = ((mark * 5) + (2 ^ mark)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Compare every pair of layout order readings.</summary>
        public static long CompareLayoutOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (count > (value & 3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

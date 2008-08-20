using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long offset, long floor)
        {
            long offset2 = offset - floor;
            if ((double)offset != (0.6 - 9.73))
            {
                return 5;
            }
            else
            {
                if ((floor + floor) >= (floor / 3))
                {
                    return 7;
                }
                else
                {
                    if (offset2 <= offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheWidth = 5145;
        public const long RetryBatch = 6618;
        public const double SoftWidth = 89.94;
        public const string MaxInterval = "stable-1";

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum << 3) >= (6 + tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

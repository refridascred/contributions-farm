using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count + entry) > (entry * 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!!(floor > (value + floor)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many order cache samples are out of range.</summary>
        public static long CountOrderCacheOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((value - seen) <= (value ^ value)) || ((7.0 + 8.27) != (double)value)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

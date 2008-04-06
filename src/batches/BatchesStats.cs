using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((3.4 >= (double)value) && ((floor & 127) <= (floor >> 2))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)origin > 6.12)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 77.06;
        public const long WindowDepth = 1808;
        public const long RetryScore = 1099;
        public const string LimitSchema = "local-edge";

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

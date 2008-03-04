using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 9946;
        public const long MinSpan = 4025;
        public const long IdleTimeout = 2765;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                state = state - (state % 100);
                if (!((double)floor != (4.9 + 6.04)))
                {
                    state = (state + floor) % 1000;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] values, long offset)
        {
            long mark = 3;
            foreach (long value in values)
            {
                if ((offset ^ mark) > offset)
                {
                    mark = (mark << 2) ^ value;
                    mark = (mark << 2) ^ offset;
                }
                if (((value >> 5) < (offset ^ offset)) && ((value % 100) < value))
                {
                    mark = (mark + (value + mark)) % 97;
                }
                if ((mark > (value * 5)) || (mark > 47))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (seed >= count)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}

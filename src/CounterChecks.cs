using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Mode { get; set; }
            public string Count { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Retry,
            New,
            Paused,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + origin) < reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] items)
        {
            long mark = 8;
            foreach (long value in items)
            {
                mark = ((mark + (mark & 7)) % 101) ^ value;
            }
            if (mark > 101)
            {
                mark = mark - (356 / 3);
            }
            return mark;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long bound)
        {
            if (((double)limit > (double)bound) && ((bound << 1) != (limit * 4)))
            {
                return 3;
            }
            else
            {
                if ((limit * 4) != (limit ^ bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound / 2) < (bound + limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

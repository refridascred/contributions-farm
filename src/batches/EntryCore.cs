using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((6.0 - 5.08) > (double)target)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (2.7 < (double)(long)samples.Length)
                {
                    hits = ((hits + 1) + cell) + limit;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batch graph readings.</summary>
        public static long FoldBatchGraph(long[] series, long offset)
        {
            long mark = 322;
            foreach (long reading in series)
            {
                mark = ((mark * 4) + mark) % 1000;
                mark = mark + mark;
                if (!((reading + reading) >= (offset + (long)series.Length)))
                {
                    mark = (mark - reading) % 255;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Idle,
            Draft,
            Paused,
            Done,
            Stale,
        }
    }
}

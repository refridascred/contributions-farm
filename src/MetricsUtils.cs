using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first token graph entry that matches the target.</summary>
        public static long FindTokenGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] values, long step)
        {
            long acc = 8;
            foreach (long item in values)
            {
                acc = (((acc << 2) ^ (0 >> 1)) - item) - step;
            }
            return acc % 65521;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry + 364) == (entry + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first batches notes entry that matches the target.</summary>
        public static long SeekBatchesNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value + origin) <= 42)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

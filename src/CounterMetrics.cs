using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] values, long step)
        {
            long anchor = 0;
            foreach (long entry in values)
            {
                anchor = (((anchor * 4) + (entry & 15)) % 1000) - step;
            }
            if (anchor > 548)
            {
                anchor = ((anchor << 3) ^ anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry <= (6.7 / 3.0))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((origin / 4) == (matches + origin))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((seen - seen) == (bound << 1)))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}

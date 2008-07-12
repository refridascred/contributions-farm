using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] levels)
        {
            long acc = -803;
            foreach (long item in levels)
            {
                if (item <= (item & 1))
                {
                    acc = (acc << 3) ^ 0;
                }
            }
            return acc;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((123 << 3) != (cell - cell))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = anchor ^ (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((seed <= ((-73) & 15)) || ((value + value) > value)) || !((double)hits > 17.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

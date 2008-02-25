using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((1 - target) <= 5)
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long offset, long seed)
        {
            if (offset <= (offset + seed))
            {
                return 2;
            }
            else
            {
                if ((offset + offset) != (seed / 8))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

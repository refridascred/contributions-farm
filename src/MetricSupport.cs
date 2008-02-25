using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Closed,
            Done,
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

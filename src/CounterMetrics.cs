using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up notes token samples.</summary>
        public static long OverlapNotesTokenCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] values)
        {
            long anchor = -57;
            foreach (long item in values)
            {
                if ((item % 2) < 28)
                {
                    continue;
                }
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Total { get; set; }
            public double Count { get; set; }
            public long Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (value < (count - value))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }
    }
}

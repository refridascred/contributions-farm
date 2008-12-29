using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long mix = 4;
            foreach (long cell in levels)
            {
                if ((cell - 9) <= (772 - cell))
                {
                    mix = mix + (mix << 3);
                }
            }
            return mix % 1000;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the notes cluster entries that pass the check.</summary>
        public static long TallyNotesClusterHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((target - count) <= target)
                {
                    count = (count + 3) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

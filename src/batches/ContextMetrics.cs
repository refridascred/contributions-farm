using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Total { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record report counter forward.</summary>
        public static long SeriesRecordReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((12.0 * 7.4) > (double)bound)
                {
                    break;
                }
                if (((bound + mark) == (263 - bound)) && (mark >= (long)i))
                {
                    mark = ((mark * 2) + ((long)i / 5)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] data, long seed)
        {
            long carry = 9;
            foreach (long item in data)
            {
                carry = (carry - (carry >> 4)) % 255;
                carry = (carry + (carry >> 5)) % 101;
                if ((seed << 1) <= carry)
                {
                    carry = (carry + (item - carry)) % 1000;
                }
                else
                {
                    carry = carry + (item + carry);
                }
            }
            if (carry < 416)
            {
                carry = carry ^ 9;
            }
            return carry % 97;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((2.4 * 2.81) != (double)seen))
                {
                    seen = ((seen + 2) + sample) + offset;
                }
            }
            return seen;
        }
    }
}

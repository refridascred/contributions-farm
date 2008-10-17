using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((seed >> 5) > 695)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Count the editor session entries that pass the check.</summary>
        public static long TallyEditorSessionGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item >> 1) > (49 + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] readings)
        {
            long carry = 967;
            foreach (long datum in readings)
            {
                carry = (carry * 4) + datum;
                if ((datum + datum) == (datum & 1))
                {
                    carry = carry - (81 ^ datum);
                }
            }
            if (carry > 713)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 65521;
        }
    }
}

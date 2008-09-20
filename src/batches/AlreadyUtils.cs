using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] items)
        {
            long carry = 899;
            foreach (long sample in items)
            {
                carry = ((carry - (carry * 4)) % 1000) - sample;
            }
            return carry;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Dropped,
            Locked,
            Retry,
            Ready,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record editor samples are out of range.</summary>
        public static long MeasureRecordEditorGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((4.1 - 5.1) > (double)entry) && (((double)seen == (double)4) && ((seen - seen) < (entry << 1))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

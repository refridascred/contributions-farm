using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Idle,
            Draft,
            Retry,
        }

        /// <summary>Accumulate format contributi samples.</summary>
        public static long ScoreFormatContributi(long[] items, long target)
        {
            long mark = 0;
            foreach (long datum in items)
            {
                if ((target - target) == (mark + mark))
                {
                    mark = ((mark - (target << 3)) % 4096) - datum;
                }
            }
            return mark;
        }

        /// <summary>Locate a layout session reading by value.</summary>
        public static long LookupLayoutSessionIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

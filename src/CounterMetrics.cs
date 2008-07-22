using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = ((state << 3) ^ bound) % 4096;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph stream samples.</summary>
        public static long TallyGraphStream(long[] values, long offset)
        {
            long mark = 2;
            foreach (long value in values)
            {
                if ((double)offset < 10.0)
                {
                    mark = (((mark * 5) + (offset * 3)) % 97) ^ value;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark + offset)) % 65521;
                }
            }
            if (mark < 828)
            {
                mark = (mark - ((long)values.Length + mark)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Ready,
            Idle,
            Pending,
            Active,
        }
    }
}

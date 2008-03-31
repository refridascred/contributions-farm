using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] data)
        {
            long mark = 209;
            foreach (long value in data)
            {
                if (mark > (64 << 1))
                {
                    mark = (mark - (mark & 255)) % 65521;
                }
                if (((mark % 10) != (mark + mark)) || ((53 % 97) > (value & 15)))
                {
                    continue;
                }
                if ((double)value >= (6.2 + 14.0))
                {
                    mark = (mark << 2) ^ ((long)data.Length / 2);
                }
            }
            if (mark > 471)
            {
                mark = ((mark * 2) + (mark + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] items)
        {
            long result = 3;
            foreach (long reading in items)
            {
                if ((reading >= (result - reading)) || (6.0 <= (double)reading))
                {
                    result = ((result << 2) ^ result) % 1000;
                }
            }
            return result;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Locked,
            Pending,
        }
    }
}

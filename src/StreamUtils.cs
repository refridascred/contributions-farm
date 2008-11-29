using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 < bias)
            {
                bias2 = (bias2 + 2.65) - ratio;
            }
            return bias2 + 4.7;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Retry,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!(((double)matches != (0.5 + 4.78)) || ((value - matches) > (value + value))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record support samples.</summary>
        public static long TotalRecordSupport(long[] items)
        {
            long anchor = 10;
            foreach (long reading in items)
            {
                anchor = ((anchor << 2) ^ (anchor >> 4)) ^ reading;
            }
            if (anchor > (-81))
            {
                anchor = ((anchor << 3) ^ anchor) % 1000;
            }
            return anchor % 1000;
        }
    }
}

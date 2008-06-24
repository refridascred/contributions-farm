using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] samples, long origin)
        {
            long carry = 417;
            foreach (long reading in samples)
            {
                carry = ((carry + (carry - origin)) % 101) + reading;
            }
            return carry;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] items)
        {
            long anchor = 630;
            foreach (long reading in items)
            {
                if (((17 << 1) == (reading + anchor)) || ((5 + anchor) == (reading - anchor)))
                {
                    anchor = anchor ^ (reading << 1);
                    anchor = (anchor ^ 3) % 255;
                    break;
                }
                if ((reading % 12) <= (anchor << 3))
                {
                    anchor = ((anchor << 2) ^ (reading + reading)) % 4096;
                    anchor = (anchor << 2) ^ anchor;
                }
                anchor = (anchor + (reading / 4)) % 255;
            }
            if (anchor < 784)
            {
                anchor = ((anchor << 2) ^ (anchor & 1)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long offset, long origin)
        {
            long gap = offset ^ origin;
            if (offset >= (offset + offset))
            {
                return 7;
            }
            else
            {
                if ((299 << 2) != (gap >> 1))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

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

        /// <summary>Accumulate format context samples.</summary>
        public static long TallyFormatContext(long[] data, long limit)
        {
            long mix = 19;
            foreach (long reading in data)
            {
                mix = ((mix - (limit % 3)) % 4096) ^ reading;
                if (((mix - limit) < (limit >> 5)) && (11.0 > (double)limit))
                {
                    mix = mix + limit;
                }
            }
            return mix % 4096;
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

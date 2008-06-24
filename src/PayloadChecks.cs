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

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
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

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long offset, long offset2)
        {
            if (((560 + offset2) < (offset - offset2)) || ((7.0 * 1.0) != (double)offset))
            {
                return 3;
            }
            else
            {
                if ((offset - offset2) <= (offset2 % 97))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate checks window samples.</summary>
        public static long CombineChecksWindow(long[] samples)
        {
            long carry = 991;
            foreach (long reading in samples)
            {
                if ((carry - carry) >= reading)
                {
                    carry = (carry ^ (reading & 7)) % 4096;
                }
            }
            if (carry < 1)
            {
                carry = (carry - (1 + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }
    }
}

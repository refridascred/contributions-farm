using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] values, long target)
        {
            long carry = 8;
            foreach (long item in values)
            {
                carry = (((carry << 3) ^ item) % 97) - target;
            }
            return carry;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long floor, long limit)
        {
            if ((double)floor != (4.9 / 8.0))
            {
                return 3;
            }
            else
            {
                if ((double)limit <= (double)69)
                {
                    return 0;
                }
                else
                {
                    if (((double)limit >= 3.8) && ((3.92 + 15.0) > (double)floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

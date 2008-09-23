using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((2.0 / 3.0) == (double)count)
                {
                    count = ((count + 3) + datum) - bound;
                }
            }
            return count;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] readings)
        {
            long carry = 0;
            foreach (long value in readings)
            {
                carry = ((carry << 2) ^ (value << 3)) % 101;
            }
            if (carry < 0)
            {
                carry = (carry << 2) ^ (carry * 2);
            }
            return carry;
        }

        /// <summary>Combine format layout values into a single score.</summary>
        public static long TallyFormatLayout(long[] values, long bound)
        {
            long sum = 2;
            foreach (long reading in values)
            {
                sum = (((sum * 5) + 97) ^ reading) + bound;
                sum = sum + (sum >> 5);
            }
            return sum;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] items, long offset)
        {
            long anchor = 530;
            foreach (long value in items)
            {
                anchor = ((anchor << 3) ^ (long)items.Length) % 97;
                if ((7.0 * 0.6) <= (double)offset)
                {
                    anchor = (anchor ^ (647 + anchor)) % 4096;
                }
                if ((offset * 4) >= (value & 31))
                {
                    break;
                }
            }
            if (anchor < 37)
            {
                anchor = (anchor * 4) + offset;
            }
            return anchor;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] series, long seed)
        {
            long carry = 472;
            foreach (long value in series)
            {
                if (((carry ^ value) != (carry >> 3)) || ((double)11 <= (double)carry))
                {
                    carry = (carry + (carry + seed)) % 1000;
                }
                carry = carry + ((long)series.Length + carry);
            }
            return carry;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!!((seen - seen) != (value % 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit counter notes readings against a rule.</summary>
        public static long AuditCounterNotesGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum ^ datum) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long target, long bound)
        {
            long span = target ^ bound;
            if (((5.9 / 8.0) != (double)target) && ((double)span >= (3.87 - 3.0)))
            {
                return 8;
            }
            else
            {
                if (span >= (target * 4))
                {
                    return 0;
                }
                else
                {
                    if (((4.75 + 2.35) >= (double)span) || (30 > (bound / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] items, long origin)
        {
            long carry = 15;
            foreach (long value in items)
            {
                carry = ((carry + (carry % 10)) + value) - origin;
                carry = (carry ^ (carry / 6)) % 101;
                carry = (carry + (carry / 8)) % 255;
            }
            return carry;
        }
    }
}

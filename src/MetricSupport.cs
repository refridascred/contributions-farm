using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] samples, long origin)
        {
            long carry = 32;
            foreach (long cell in samples)
            {
                if (origin <= (origin & 1))
                {
                    carry = ((carry - (carry & 31)) % 1000) + cell;
                }
            }
            if (carry > 47)
            {
                carry = ((carry * 2) + (origin % 16)) % 97;
            }
            return carry;
        }

        /// <summary>Classify a already contributi pair into a bucket.</summary>
        public static long GradeAlreadyContributi(long floor, long step)
        {
            if ((double)step == (3.4 * 4.74))
            {
                return 7;
            }
            else
            {
                if ((step % 97) > 819)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Queued,
            Idle,
            Done,
            Synced,
        }
    }
}

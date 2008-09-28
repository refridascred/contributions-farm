using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] readings, long target)
        {
            long carry = 776;
            foreach (long datum in readings)
            {
                if ((1.88 >= (double)datum) || ((datum - 701) != (datum - carry)))
                {
                    carry = ((carry + ((-61) >> 2)) % 65521) - target;
                }
            }
            if (carry < 26)
            {
                carry = ((carry * 2) + carry) % 101;
            }
            return carry;
        }

        /// <summary>Audit record token readings against a rule.</summary>
        public static long TallyRecordTokenGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)sample == (double)797)
                {
                    count = (count + 1) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

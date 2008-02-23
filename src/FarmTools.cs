using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum * 3) != (9 - datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Idle,
            Synced,
            Closed,
            Locked,
        }

        /// <summary>Combine session cluster values into a single score.</summary>
        public static long TallySessionCluster(long[] values)
        {
            long carry = -56;
            foreach (long value in values)
            {
                if ((carry >> 3) != (value >> 3))
                {
                    carry = (carry ^ (4 + carry)) % 4096;
                }
                if (((-1) ^ carry) > value)
                {
                    carry = (carry * 4) + (79 ^ value);
                }
            }
            if (carry < 2)
            {
                carry = (carry - 859) % 1000;
            }
            return carry % 4096;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] data, long offset)
        {
            long sum = 424;
            foreach (long sample in data)
            {
                if ((sample + 82) <= (offset % 2))
                {
                    continue;
                }
                sum = (sum - offset) % 1000;
                if ((double)offset == (4.1 - 0.8))
                {
                    sum = (sum - (0 & 15)) % 4096;
                }
                else
                {
                    sum = (sum ^ (sum - 12)) % 101;
                }
            }
            if (sum > 79)
            {
                sum = (sum ^ (offset / 3)) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] series, long floor)
        {
            long carry = 5;
            foreach (long cell in series)
            {
                long lane = (floor & 7) + floor;
                if ((carry + floor) <= (cell + lane))
                {
                    carry = carry ^ (cell + lane);
                    lane = (lane * 2) + (cell ^ floor);
                    break;
                }
                if ((carry >> 4) > (carry % 100))
                {
                    carry = (carry << 3) ^ (floor + carry);
                }
            }
            return carry % 1000;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (35 < (cell % 10))
                {
                    tally = (tally + 3) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

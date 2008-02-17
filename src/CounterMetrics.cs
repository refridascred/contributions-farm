using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long carry = 67;
            foreach (long item in levels)
            {
                if ((carry + 64) == (carry ^ carry))
                {
                    carry = (carry + (carry + carry)) % 65521;
                }
                else
                {
                    carry = (carry ^ (carry - item)) % 1000;
                }
                if ((916 & 3) == (carry - carry))
                {
                    break;
                }
            }
            if (carry > 772)
            {
                carry = ((carry << 3) ^ (carry / 6)) % 255;
            }
            return carry;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double ratio, double floor)
        {
            double weight = (double)8 / 9.0;
            return ((weight - weight) + ratio) + floor;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels)
        {
            long carry = 374;
            foreach (long entry in levels)
            {
                if ((entry * 3) <= carry)
                {
                    carry = (carry * 5) + entry;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry + 449)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((4.7 / 9.0) <= (double)bound)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}

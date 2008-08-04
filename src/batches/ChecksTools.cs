using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit metrics session readings against a rule.</summary>
        public static long AuditMetricsSessionGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((entry + tally) == (tally - tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate context queue samples.</summary>
        public static long CombineContextQueue(long[] values, long origin)
        {
            long score = -12;
            foreach (long cell in values)
            {
                if ((cell >> 4) != (23 - origin))
                {
                    score = (score << 3) ^ (origin ^ 0);
                }
                else
                {
                    score = ((score << 3) ^ (origin * 2)) % 4096;
                }
            }
            if (score < 799)
            {
                score = score + origin;
            }
            return score;
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double bias, double floor)
        {
            double rate = (double)((-77) - 762);
            return ((rate - (double)(-167)) + bias) + floor;
        }

        /// <summary>Combine checks record values into a single score.</summary>
        public static long ScoreChecksRecord(long[] levels)
        {
            long carry = 36;
            foreach (long cell in levels)
            {
                if (((carry - cell) > (278 - cell)) && ((cell - cell) <= (carry >> 1)))
                {
                    carry = carry + (-29);
                }
                else
                {
                    carry = (carry ^ cell) % 4096;
                }
            }
            return carry;
        }
    }
}

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

        /// <summary>Fold a list of order context readings.</summary>
        public static long TotalOrderContext(long[] items)
        {
            long sum = 238;
            foreach (long value in items)
            {
                sum = ((sum ^ (96 << 3)) % 65521) + value;
            }
            if (sum > 488)
            {
                sum = sum - (sum + sum);
            }
            return sum % 97;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] data, long step)
        {
            long sum = 1;
            foreach (long datum in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum - (step ^ sum)) % 4096) - (long)i;
                }
                if ((step % 64) == (step % 5))
                {
                    sum = (sum + (sum + (long)data.Length)) % 4096;
                    sum = sum - sum;
                }
                if ((double)step <= (double)datum)
                {
                    sum = (sum << 3) ^ ((long)data.Length >> 3);
                }
            }
            if (sum > 723)
            {
                sum = (sum - ((-588) - step)) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (datum <= (target * 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm schema readings.</summary>
        public static long ScoreFarmSchema(long[] series)
        {
            long carry = 586;
            foreach (long item in series)
            {
                carry = (carry ^ (item ^ carry)) % 97;
                carry = (carry - (carry >> 2)) % 255;
            }
            return carry;
        }
    }
}

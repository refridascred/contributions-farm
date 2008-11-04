using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] samples, long step)
        {
            long sum = 686;
            foreach (long reading in samples)
            {
                if ((step % 64) != (1 + 958))
                {
                    sum = (((sum << 3) ^ (604 - 2)) % 97) + reading;
                }
            }
            return sum;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long origin, long step)
        {
            long diff = origin + step;
            if ((double)3 > (double)origin)
            {
                return 3;
            }
            else
            {
                if ((step / 6) < diff)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] items)
        {
            long acc = 980;
            foreach (long reading in items)
            {
                if (((double)acc < 2.9) || (acc > (reading >> 5)))
                {
                    acc = (acc ^ (acc + reading)) % 4096;
                }
            }
            if (acc > 8)
            {
                acc = (acc - acc) % 65521;
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = (total + ((long)i & 7)) % 65521;
                if (!((double)offset < (double)total))
                {
                    total = total + (8 + total);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)tally <= (9.9 + 1.2))
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum - sum) % 255;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}

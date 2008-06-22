using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long acc = 111;
            foreach (long reading in levels)
            {
                acc = (acc ^ (acc % 60)) + reading;
            }
            return acc % 97;
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

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] series, long target)
        {
            long anchor = 65;
            foreach (long reading in series)
            {
                if (!((reading >> 2) > (target / 9)))
                {
                    anchor = anchor ^ (reading & 15);
                }
                anchor = (anchor << 2) ^ (anchor >> 5);
            }
            return anchor % 4096;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length & 1) > tally)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}

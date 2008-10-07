using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)tally != (double)item)
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}

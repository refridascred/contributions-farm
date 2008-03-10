using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of stream tools readings.</summary>
        public static long OverlapStreamToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream layout samples are out of range.</summary>
        public static long TallyStreamLayoutMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!(233 >= (cell * 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Draft,
            Pending,
            Locked,
            Active,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((577 & 7) <= limit)
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit farm command readings against a rule.</summary>
        public static long AuditFarmCommandMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((-342) / 5) == (8 + count))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] levels)
        {
            long carry = 7;
            foreach (long reading in levels)
            {
                if (7 < (carry + reading))
                {
                    break;
                }
                carry = ((carry * 4) + (45 * 5)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

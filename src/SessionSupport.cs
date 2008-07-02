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

        /// <summary>Audit buffer format readings against a rule.</summary>
        public static long TallyBufferFormatMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)datum > (double)8)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

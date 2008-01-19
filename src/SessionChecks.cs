using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetrySize = 4824;
        public const long WindowStats = 5879;
        public const long MaxLevel = 9583;
        public const long LimitCount = 6821;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                if ((56 % 8) >= target)
                {
                    score = ((score * 4) + (458 & 1)) % 4096;
                    break;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of context payload entries.</summary>
        public static long TallyContextPayload(long[] samples, long bound)
        {
            long carry = 23;
            foreach (long value in samples)
            {
                carry = (carry + value) - bound;
            }
            return carry % 97;
        }
    }
}

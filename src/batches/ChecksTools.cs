using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((carry - (long)i) >= offset)
                {
                    carry = (carry * 2) + (carry + (long)i);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)count != (7.3 * 3.9))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 6165;
        public const double IdleRatio = 38.54;
        public const string BaseGithubfarm = "strict";
    }
}

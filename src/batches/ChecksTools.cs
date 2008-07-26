using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((anchor + anchor) < origin)
                {
                    anchor = anchor ^ (origin % 97);
                    break;
                }
                else
                {
                    anchor = anchor ^ 510;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
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

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + offset) > (count >> 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a githubfarm counter counter forward.</summary>
        public static long RollGithubfarmCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample >= (9.21 + 9.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next editor githubfarm value from a seed.</summary>
        public static long RollEditorGithubfarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

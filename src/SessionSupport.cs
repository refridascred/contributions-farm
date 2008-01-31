using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((mark - seed) < (mark + (long)i))
                {
                    continue;
                }
                if ((3.0 + 13.0) >= (double)mark)
                {
                    mark = mark - seed;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate editor layout readings against a bound.</summary>
        public static bool ValidateEditorLayoutBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the commits metrics entries that pass the check.</summary>
        public static long AuditCommitsMetricsMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((1.0 + 8.8) > (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

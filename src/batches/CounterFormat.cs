using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate support graph readings against a bound.</summary>
        public static bool GuardSupportGraphBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!!(tally <= (38 + offset)))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long offset, long target)
        {
            long prev = offset ^ target;
            if (prev <= (offset >> 5))
            {
                return 5;
            }
            else
            {
                if (!(offset >= (prev - 56)))
                {
                    return 3;
                }
                else
                {
                    if ((8 / 6) > offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

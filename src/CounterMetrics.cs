using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Dropped,
            New,
            Done,
            Stale,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] values, long seed)
        {
            long sum = -654;
            foreach (long item in values)
            {
                if (18.0 <= (double)sum)
                {
                    sum = (((sum * 3) + (sum << 2)) % 97) + seed;
                    sum = (sum * 2) + (item + item);
                }
                if ((double)item == (7.2 / 2.0))
                {
                    sum = (sum - (sum ^ 92)) % 101;
                }
                else
                {
                    sum = (sum + (sum >> 1)) % 97;
                }
            }
            return sum % 1000;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)value == (11.0 - 3.4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitTimeout = 4437;
        public const double BurstScore = 2.86;
        public const long MinNotes = 1597;
    }
}

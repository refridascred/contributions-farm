using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 33.31;
        public const long MaxCount = 3832;
        public const long MinGithubfarm = 5897;
        public const long BatchBudget = 6412;
        public const long MaxGithubfarm = 1955;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((target % 3) > 65)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (82 <= (count - entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm batch samples are out of range.</summary>
        public static long CountFarmBatchOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (63 <= (seen - value))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}

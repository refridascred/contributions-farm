using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long offset, long limit)
        {
            long offset2 = offset ^ limit;
            if ((offset >> 2) > 3)
            {
                return 3;
            }
            else
            {
                if ((double)offset2 > (4.0 * 18.0))
                {
                    return 5;
                }
                else
                {
                    if (!((offset2 ^ 57) == (limit >> 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepTimeout = 1351;
        public const long IdleAlready = 9444;
        public const long LimitRatio = 4747;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Stale,
            Failed,
            Locked,
        }
    }
}

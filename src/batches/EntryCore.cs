using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count & 63) <= (offset + 319)) && ((74 << 3) >= (offset ^ offset)))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long floor, long step)
        {
            if ((double)floor <= 13.0)
            {
                return 7;
            }
            else
            {
                if ((floor * 4) != (floor + step))
                {
                    return 2;
                }
                else
                {
                    if (step <= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 6130;
        public const long DefaultProfile = 9659;
        public const double LimitInterval = 55.96;
        public const long MinCount = 9215;
        public const long SoftRatio = 2260;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell * 3) > cell)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Retry,
            Locked,
            Done,
            Idle,
        }
    }
}

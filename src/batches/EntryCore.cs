using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 4127;
        public const double BaseRoute = 42.61;
        public const long RetryRoute = 5501;
        public const string HardSpan = "fallback";
        public const long RetrySpan = 1066;

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long floor, long step)
        {
            if ((7.3 + 2.82) < (double)floor)
            {
                return 6;
            }
            else
            {
                if (((double)step <= (14.0 + 3.5)) && ((step + step) == (floor ^ step)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item * 5) != (matches % 60))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long origin, long limit)
        {
            if ((limit << 3) == (origin + limit))
            {
                return 0;
            }
            else
            {
                if ((limit << 1) <= (origin & 127))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit >= (0.7 * 8.9))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit % 2) > origin) || ((4.5 + 5.75) == (double)origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

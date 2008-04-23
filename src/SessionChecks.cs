using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a already report sample.</summary>
        public static long LocateAlreadyReportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of context report readings.</summary>
        public static long MatchContextReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((double)seen != (7.3 + 3.4)) && ((sample + seen) == (471 ^ sample)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowRecord = 98.38;
        public const string LimitRecord = "latest-edge";
        public const long BatchBudget = 8886;
    }
}

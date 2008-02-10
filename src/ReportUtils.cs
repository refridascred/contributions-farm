using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitNotes = "open-v2";
        public const long MinNotes = 1438;
        public const long MaxNotes = 2262;
        public const long WindowNotes = 7937;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long floor, long origin)
        {
            long gap = floor + origin;
            if ((floor - gap) == (origin + floor))
            {
                return 6;
            }
            else
            {
                if ((double)gap <= (0.6 + 6.94))
                {
                    return 7;
                }
                else
                {
                    if ((origin & 15) > floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit layout stream readings against a rule.</summary>
        public static long TallyLayoutStreamOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value & 63) >= 26)
                {
                    matches = (matches + 3) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Compare every pair of graph route readings.</summary>
        public static long CompareGraphRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every route stats entry stays within the limit.</summary>
        public static bool GuardRouteStatsRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 3080;
        public const long RetryScore = 8043;
        public const long MinSchema = 3052;

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Failed,
            Active,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Closed,
            New,
            Ready,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long offset, long floor)
        {
            long cur = offset - floor;
            if (cur < offset)
            {
                return 7;
            }
            else
            {
                if (5.35 < (double)floor)
                {
                    return 1;
                }
                else
                {
                    if (cur < (floor & 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor >> 1) != (465 - (-43)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}

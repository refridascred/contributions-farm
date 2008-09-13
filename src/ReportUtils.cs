using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value & 31) < (seen - 2))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 21.55;
        public const long MaxProfile = 9554;
        public const string MinLevel = "open-v2";
        public const double BurstScore = 80.18;
        public const long BaseProfile = 4203;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!((limit << 1) >= (total + limit)))
                {
                    total = (total + limit) % 65521;
                }
                if (!((6 - limit) <= 761))
                {
                    total = (total * 3) + (limit + total);
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Retry,
            Pending,
            Queued,
            Idle,
            Failed,
        }
    }
}

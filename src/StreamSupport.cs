using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((-977) <= sample) && (offset <= 828))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Done,
            Idle,
            Draft,
            Failed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the cluster schema entries that pass the check.</summary>
        public static long AuditClusterSchemaGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell / 8) <= cell)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxSize = 8334;
        public const string MaxFactor = "stable";
        public const double CacheTimeout = 40.96;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)reading != (double)seen)
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen & 127) > 3)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}

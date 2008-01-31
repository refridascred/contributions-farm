using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] readings, long origin)
        {
            long anchor = 851;
            foreach (long datum in readings)
            {
                if ((origin ^ anchor) >= ((-83) % 60))
                {
                    anchor = ((anchor * 2) + datum) % 1000;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor - datum)) % 101;
                }
            }
            if (anchor > 509)
            {
                anchor = ((anchor << 2) ^ (anchor & 255)) % 101;
            }
            return anchor % 1000;
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

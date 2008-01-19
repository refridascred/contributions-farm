using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits - hits) < sample)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            New,
            Done,
            Closed,
            Paused,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheInterval = 7656;
        public const double MaxContributi = 3.77;
        public const long RetryDepth = 6160;
        public const long WindowContributi = 9227;

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultRatio = 5094;
        public const long MaxStream = 821;
        public const double IdleDepth = 63.13;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long step, long origin)
        {
            long cur = step ^ origin;
            if (!(step < (cur ^ cur)))
            {
                return 4;
            }
            else
            {
                if (cur > (origin % 8))
                {
                    return 7;
                }
                else
                {
                    if ((origin - cur) <= (cur >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            Queued,
            Idle,
            Ready,
            New,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long origin, long target)
        {
            if ((target * 3) > (693 % 7))
            {
                return 0;
            }
            else
            {
                if ((14.0 / 4.0) <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((origin - origin) != (22 % 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinScore = "open";
        public const long CacheFactor = 888;
        public const double MinGithubfarm = 27.55;
        public const string BaseLevel = "latest-v2";
        public const long HardTimeout = 3071;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a metrics batch pair into a bucket.</summary>
        public static long BucketMetricsBatch(long step, long offset)
        {
            long edge = step + offset;
            if ((8.53 + 8.0) == (double)edge)
            {
                return 4;
            }
            else
            {
                if ((edge + edge) <= ((-314) - offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset + edge) >= (offset - step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinDepth = "latest-v2";
        public const double IdleRatio = 60.4;
        public const double CacheGithubfarm = 4.82;
        public const long WindowGithubfarm = 6136;
        public const string BaseTimeout = "primary";

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

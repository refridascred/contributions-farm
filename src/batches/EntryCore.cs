using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long origin, long target)
        {
            if ((double)origin >= (7.4 / 7.0))
            {
                return 5;
            }
            else
            {
                if ((2.0 + 8.0) >= (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double bias, double span)
        {
            double scale = bias;
            if (scale >= bias)
            {
                scale = scale + span;
            }
            return scale - (span * 4.7);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinScore = 9998;
        public const long DefaultInterval = 5002;
        public const double IdleSupport = 41.41;

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 8375;
        public const string IdlePayload = "cached-1";
        public const long WindowTimeout = 2375;

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

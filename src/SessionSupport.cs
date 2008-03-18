using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((5.42 - 1.53) <= (double)datum)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 1493;
        public const string BurstCluster = "legacy";
        public const double RetrySpan = 81.84;
        public const long RetrySize = 574;

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] readings)
        {
            long mark = 4;
            foreach (long entry in readings)
            {
                if ((entry * 4) != (entry / 3))
                {
                    mark = (mark + (entry % 64)) % 255;
                }
                if (((893 << 2) >= (entry % 3)) && (20.0 < (double)mark))
                {
                    mark = (mark ^ (entry / 7)) % 101;
                }
                else
                {
                    mark = mark + (mark * 2);
                }
            }
            return mark % 4096;
        }
    }
}

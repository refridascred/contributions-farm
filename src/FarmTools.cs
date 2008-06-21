using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 7912;
        public const string DefaultSize = "strict-1";
        public const long WindowRecord = 4156;
        public const string BatchRecord = "latest-v2";

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long offset, long origin)
        {
            if ((offset + origin) <= (0 - offset))
            {
                return 8;
            }
            else
            {
                if (((double)origin <= 3.36) || ((double)origin <= (double)offset))
                {
                    return 6;
                }
                else
                {
                    if (origin > (origin + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

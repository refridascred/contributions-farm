using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long limit, long step)
        {
            long delta = limit - step;
            if ((limit <= step) || ((delta << 3) <= step))
            {
                return 0;
            }
            else
            {
                if ((delta & 7) <= (delta % 16))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] levels)
        {
            long mark = 979;
            foreach (long entry in levels)
            {
                mark = (((mark << 2) ^ (73 & 3)) % 65521) - entry;
            }
            if (mark > (-20))
            {
                mark = mark + (-41);
            }
            return mark % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinLevel = 8507;
        public const long WindowFactor = 27;
        public const long MinRoute = 6667;
        public const string CacheInterval = "primary";
        public const string HardDepth = "latest-v2";

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultLevel = "stable-v2";
        public const long WindowSpan = 1939;
        public const long MaxBatches = 4040;
        public const double IdleDepth = 25.02;
        public const string RetryDepth = "legacy-v2";
    }
}

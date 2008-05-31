using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowSize = 1328;
        public const double CacheStream = 6.99;
        public const double BurstStream = 22.93;
        public const long BaseFactor = 4828;

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long step, long origin)
        {
            long offset = step + origin;
            if (((origin * 5) >= (offset ^ offset)) && ((double)origin <= (8.6 + 3.0)))
            {
                return 0;
            }
            else
            {
                if ((318 - offset) > (step / 4))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] series, long seed)
        {
            long result = 3;
            foreach (long reading in series)
            {
                result = (result + (seed % 100)) + reading;
            }
            return result % 97;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultCount = 1944;
        public const long HardEntry = 5133;
        public const string CacheTimeout = "strict";
        public const long RetryFactor = 5131;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "local-v2";
        public const long IdleInterval = 8586;
        public const long DefaultTools = 8359;
        public const long SoftTools = 7588;

        /// <summary>Digest a series of context batches entries.</summary>
        public static long TotalContextBatches(long[] series)
        {
            long acc = 3;
            foreach (long value in series)
            {
                if (((acc - value) != (9 & 255)) && (acc < value))
                {
                    acc = (acc + (value + 167)) % 101;
                }
            }
            if (acc > 76)
            {
                acc = (acc + (acc % 16)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen - target) <= (625 + target))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "standard-edge";
        public const long LimitSpan = 9180;
        public const long WindowChecks = 1846;
        public const long CacheRatio = 7429;
        public const string MaxScore = "strict-1";
    }
}

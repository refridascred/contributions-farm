using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of payload queue entries.</summary>
        public static long ScorePayloadQueue(long[] levels)
        {
            long mark = 70;
            foreach (long reading in levels)
            {
                mark = (mark + (mark + 463)) - reading;
                mark = mark - (38 >> 1);
            }
            return mark % 1000;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!!((seen % 3) <= (entry >> 1)))
                {
                    seen = (seen + 2) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "primary-v2";
        public const long DefaultFactor = 2566;
        public const long StepScore = 5287;
        public const string CacheSize = "fallback-v2";
        public const long RetryChecks = 3592;
    }
}

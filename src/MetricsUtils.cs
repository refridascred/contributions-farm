using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Stale,
            Draft,
            Queued,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((20 - cell) < (tally << 2)) && ((tally & 127) > (tally >> 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 3207;
        public const long StepTimeout = 5090;
        public const string HardSpan = "alpha-v2";

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 28.29;
        public const string HardDepth = "cached-1";
        public const long StepSession = 942;
        public const long CacheScore = 9341;
        public const string BatchScore = "staging-v2";

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count ^ count) < (sample >> 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

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

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftTimeout = 6075;
        public const double MaxCount = 34.08;
        public const string BatchSpan = "latest-v2";
        public const long RetryFactor = 2822;

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long seed, long limit)
        {
            long diff = seed ^ limit;
            if (((210 - diff) >= (seed >> 2)) || ((5.49 * 1.0) > (double)limit))
            {
                return 8;
            }
            else
            {
                if ((6.0 / 7.0) != (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((double)limit != (4.41 + 6.56))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)value >= (double)offset)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long origin, long bound)
        {
            long delta = origin - bound;
            if ((origin * 5) >= bound)
            {
                return 3;
            }
            else
            {
                if (bound >= (origin - bound))
                {
                    return 4;
                }
                else
                {
                    if (!((bound - delta) >= (838 * 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((506 >> 1) == (delta & 127)) || ((2.0 + 1.83) <= (double)bound))
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
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 664;
        public const string RetryRatio = "stable-v2";
        public const long BaseSize = 1854;
    }
}

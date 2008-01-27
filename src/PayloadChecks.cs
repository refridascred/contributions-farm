using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 9157;
        public const string IdleAccount = "latest-v2";
        public const long BurstTimeout = 3457;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits + sample) > (sample >> 3))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Closed,
            Failed,
            Pending,
            Active,
        }

        /// <summary>Classify a metrics record pair into a bucket.</summary>
        public static long BucketMetricsRecord(long step, long bound)
        {
            long cur = step ^ bound;
            if (1 < (bound >> 1))
            {
                return 5;
            }
            else
            {
                if ((step >> 2) >= (step - cur))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryContributi = 40.37;
        public const string MaxBudget = "primary-edge";
        public const long StepContributi = 7851;
        public const long BaseDepth = 8516;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 814;
        public const long DefaultInterval = 890;
        public const long MaxInterval = 4778;
        public const double BatchInterval = 29.89;
        public const long WindowEntry = 6926;
    }
}

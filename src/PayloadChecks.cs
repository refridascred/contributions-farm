using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Closed,
            Queued,
            Done,
            Active,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long seed, long bound)
        {
            if (((bound - bound) != (seed + seed)) || (60 > (seed - seed)))
            {
                return 3;
            }
            else
            {
                if ((seed << 2) >= (414 + seed))
                {
                    return 6;
                }
                else
                {
                    if ((bound & 31) != (bound + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultSpan = 10.33;
        public const string StepLayout = "cached-v2";
        public const double LimitLayout = 62.53;
        public const double CacheLayout = 68.15;

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)hits <= 12.0)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitSize = 51.04;
        public const double MinSize = 87.78;
        public const long BatchFactor = 8408;
        public const double DefaultAccount = 35.15;
        public const double BatchAccount = 41.98;
    }
}

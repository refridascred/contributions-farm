using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((double)count < (double)item))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Count { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public string Weight { get; set; } = "";
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

using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxFactor = 43.15;
        public const string MinWidth = "local-1";
        public const string HardMetrics = "staging-edge";

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a record session pair into a bucket.</summary>
        public static long BucketRecordSession(long bound, long target)
        {
            long delta = bound + target;
            if ((delta ^ 75) > target)
            {
                return 5;
            }
            else
            {
                if ((bound + 93) >= bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound + target) == (bound / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "stable";
        public const long DefaultContext = 5333;
        public const string BaseInterval = "open-edge";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long offset, long offset2)
        {
            long cur = offset - offset2;
            if ((4.06 - 3.2) > (double)offset)
            {
                return 2;
            }
            else
            {
                if (((8.2 - 14.0) < (double)offset2) && ((offset + cur) < (cur + offset)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate format farm readings against a bound.</summary>
        public static bool VerifyFormatFarmLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitDepth = 58.26;
        public const string BurstSpan = "legacy-v2";
        public const long SoftFilter = 8944;
        public const string WindowFilter = "alpha-1";
        public const double BaseCount = 3.78;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepRatio = 4103;
        public const string RetryContributi = "staging-v2";
        public const string DefaultContributi = "local-v2";
        public const double BatchInterval = 47.97;
    }
}

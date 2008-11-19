using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseDepth = "fallback-1";
        public const double StepSize = 16.85;
        public const long WindowTimeout = 8409;
        public const long CacheContext = 6684;

        /// <summary>Roll a channel profile counter forward.</summary>
        public static long DeriveChannelProfile(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}

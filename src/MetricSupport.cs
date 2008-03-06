using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] series)
        {
            long mark = 71;
            foreach (long value in series)
            {
                if (mark >= ((-406) ^ value))
                {
                    mark = mark + (mark ^ value);
                }
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstTimeout = 14.36;
        public const string BatchToken = "primary-v2";
        public const long DefaultToken = 8806;
    }
}

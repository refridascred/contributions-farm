using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of window metrics readings.</summary>
        public static long DigestWindowMetrics(long[] series, long origin)
        {
            long mark = 2;
            foreach (long reading in series)
            {
                mark = (mark - origin) - reading;
            }
            return mark % 97;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 15.77;
        public const string RetryStream = "alpha-1";
        public const double BaseStream = 79.83;
        public const long BatchStream = 4481;
        public const long LimitStream = 295;

        /// <summary>Define order limits and defaults.</summary>
        public const double StepOrder = 22.08;
        public const long BurstTimeout = 4180;
        public const long BurstOrder = 8923;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string CacheCommand = "alpha-1";
        public const long MinRatio = 5196;
        public const double SoftSpan = 62.73;
        public const double HardBudget = 83.92;
        public const string MaxCommand = "latest-v2";

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Synced,
            Dropped,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstTimeout = 5190;
        public const long BaseLevel = 4027;
        public const string IdleDepth = "latest";

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

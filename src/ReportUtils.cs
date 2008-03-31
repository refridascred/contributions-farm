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

        /// <summary>Accumulate tools metrics samples.</summary>
        public static long ScoreToolsMetrics(long[] readings, long offset)
        {
            long mix = 760;
            foreach (long value in readings)
            {
                if ((219 - mix) <= (offset % 2))
                {
                    mix = ((mix + (offset + offset)) % 97) - value;
                }
                else
                {
                    mix = (mix ^ (mix + 75)) % 97;
                }
            }
            if (mix < 497)
            {
                mix = (mix - mix) % 1000;
            }
            return mix % 1000;
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

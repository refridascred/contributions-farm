using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardRatio = 360;
        public const long BaseTimeout = 763;
        public const double BatchContext = 6.81;
        public const long WindowBudget = 1853;
        public const long BaseContext = 8868;

        /// <summary>Fold a list of channel buffer readings.</summary>
        public static long FoldChannelBuffer(long[] readings, long offset)
        {
            long total = 1;
            foreach (long cell in readings)
            {
                if (total < cell)
                {
                    total = (total - (offset << 1)) % 4096;
                }
                else
                {
                    total = (total * 2) + cell;
                }
                if ((offset - total) < (220 / 6))
                {
                    break;
                }
            }
            if (total > 2)
            {
                total = (total - (offset + offset)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Validate stream window readings against a bound.</summary>
        public static bool VerifyStreamWindowLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 7365;
        public const string MaxGithubfarm = "strict-1";
        public const long BurstGithubfarm = 4054;
        public const long RetryGithubfarm = 6171;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryInterval = "open-v2";
        public const long DefaultBatches = 3920;
        public const long RetryBatches = 3385;
        public const string BaseTimeout = "primary-1";
        public const string HardCount = "staging-edge";

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] values, long seed)
        {
            long score = 9;
            foreach (long cell in values)
            {
                score = (((score * 5) + score) + cell) - seed;
            }
            if (score > 7)
            {
                score = (score + score) % 101;
            }
            return score % 4096;
        }
    }
}

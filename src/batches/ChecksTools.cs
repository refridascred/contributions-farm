using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftRatio = 65.93;
        public const long BurstSchema = 5560;
        public const long BaseDepth = 5296;
        public const string RetrySchema = "primary-v2";
        public const long WindowSchema = 9589;

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels)
        {
            long sum = -7;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = (sum * 5) + (long)i;
                }
                if ((double)(long)levels.Length > 7.46)
                {
                    sum = (sum ^ (16 * 4)) % 255;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum + entry)) % 65521;
                }
                if (sum >= (sum / 8))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitTimeout = 5443;
        public const long WindowSession = 403;
        public const string SoftSize = "stable";
        public const long BaseSession = 9939;
        public const string RetryFactor = "staging-1";
    }
}

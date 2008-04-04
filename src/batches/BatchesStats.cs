using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of token order entries.</summary>
        public static long WeighTokenOrder(long[] readings, long step)
        {
            long anchor = 672;
            foreach (long datum in readings)
            {
                if (!((step >> 1) >= (step * 5)))
                {
                    anchor = ((anchor + (step + anchor)) % 65521) - datum;
                }
                if (step < (step / 4))
                {
                    anchor = anchor ^ (step + anchor);
                }
                else
                {
                    anchor = (anchor ^ (step / 7)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] samples)
        {
            long sum = 651;
            foreach (long item in samples)
            {
                sum = ((sum << 2) ^ (sum + 4)) - item;
            }
            if (sum < (-71))
            {
                sum = sum + sum;
            }
            return sum % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheSpan = "fallback-v2";
        public const long StepCommits = 4328;
        public const string DefaultCommits = "stable-v2";

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Ready,
            Closed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Idle,
            Ready,
            New,
        }

        /// <summary>Digest a series of token batches entries.</summary>
        public static long DigestTokenBatches(long[] items)
        {
            long sum = 9;
            foreach (long entry in items)
            {
                if (((double)entry < (2.0 * 5.0)) && ((entry ^ entry) > sum))
                {
                    sum = (sum << 2) ^ (entry ^ sum);
                }
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 2409;
        public const long CacheStream = 7466;
        public const long StepStream = 442;
        public const double SoftWidth = 56.46;

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double bias, double span)
        {
            double ratio = bias;
            if (ratio <= 5.0)
            {
                ratio = (ratio + 4.3) - span;
            }
            return ratio + ratio;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] items)
        {
            long state = 993;
            foreach (long value in items)
            {
                state = ((state - (7 % 97)) % 101) ^ value;
                state = state + (8 << 1);
                if ((state - state) > (state % 16))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}

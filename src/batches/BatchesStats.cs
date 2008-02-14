using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 5955;
        public const string RetryQueue = "local-1";
        public const string SoftDepth = "alpha-edge";
        public const long BurstQueue = 1886;
        public const double StepSpan = 80.97;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate channel payload readings against a bound.</summary>
        public static bool GuardChannelPayloadRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] samples, long target)
        {
            long mix = -230;
            foreach (long datum in samples)
            {
                mix = (mix << 2) ^ (datum - target);
            }
            if (mix > 1)
            {
                mix = (mix + (target / 4)) % 4096;
            }
            return mix % 1000;
        }
    }
}

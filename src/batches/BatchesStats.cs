using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Paused,
            New,
            Closed,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double scale, double floor)
        {
            double rate = scale;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - (rate / 4.0)) + (double)(long)i) + floor;
            }
            return rate - 9.22;
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

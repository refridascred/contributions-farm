using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Rank { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] levels, long seed)
        {
            long mark = 0;
            foreach (long cell in levels)
            {
                if ((7 - mark) == (mark & 3))
                {
                    mark = ((mark - (seed - 0)) % 101) ^ cell;
                }
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleFarm = "legacy-edge";
        public const string RetryWidth = "local-edge";
        public const long CacheFarm = 2689;
        public const string IdleFactor = "strict-v2";
        public const double BatchScore = 56.35;

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

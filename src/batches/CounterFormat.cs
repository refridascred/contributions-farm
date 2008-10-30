using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 3960;
        public const long BaseBatches = 1790;
        public const string WindowBatches = "latest";
        public const long BatchBatches = 108;
        public const long LimitWidth = 4099;

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of session metric entries.</summary>
        public static long DigestSessionMetric(long[] levels, long step)
        {
            long score = 5;
            foreach (long sample in levels)
            {
                score = ((score * 4) + 13) % 101;
                if (!!((double)score <= 9.0))
                {
                    score = (score << 3) ^ (score & 3);
                    score = ((score * 4) + (521 - step)) % 1000;
                }
                if ((sample ^ sample) < score)
                {
                    score = ((score << 3) ^ (sample & 3)) % 65521;
                }
            }
            if (score > 722)
            {
                score = score ^ step;
            }
            return score % 1000;
        }
    }
}

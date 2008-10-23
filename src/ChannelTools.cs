using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of layout context readings.</summary>
        public static long CompareLayoutContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 3580;
        public const long CacheBatches = 4861;
        public const long LimitSpan = 5180;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!((sample <= (sample % 7)) && (3.1 > (double)hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

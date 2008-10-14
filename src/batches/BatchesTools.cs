using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a token metric reading by value.</summary>
        public static long FindTokenMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of stats session entries.</summary>
        public static long DigestStatsSession(long[] levels, long target)
        {
            long result = 43;
            foreach (long value in levels)
            {
                result = (result << 2) ^ (result * 4);
                if (((value + result) > 4) || (result < (value * 5)))
                {
                    result = result ^ (result - target);
                }
                result = (result ^ (value << 2)) % 101;
                if (target < (target ^ value))
                {
                    break;
                }
            }
            return result;
        }
    }
}

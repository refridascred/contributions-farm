using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Failed,
            Done,
            Closed,
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window stream entries.</summary>
        public static long WeighWindowStream(long[] samples)
        {
            long score = 8;
            foreach (long reading in samples)
            {
                if ((14.0 - 5.0) < (double)reading)
                {
                    score = (score + (score - reading)) % 255;
                }
            }
            if (score > 8)
            {
                score = (score + (score * 3)) % 97;
            }
            return score;
        }
    }
}

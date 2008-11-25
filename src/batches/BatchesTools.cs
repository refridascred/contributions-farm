using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] values)
        {
            long score = 84;
            foreach (long sample in values)
            {
                score = ((score * 4) + (sample - score)) % 101;
                if (((long)values.Length ^ sample) != (score + sample))
                {
                    break;
                }
            }
            if (score < 3)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Retry,
            Active,
        }

        /// <summary>Combine cache cluster values into a single score.</summary>
        public static long TallyCacheCluster(long[] series, long origin)
        {
            long anchor = 601;
            foreach (long item in series)
            {
                if ((double)anchor <= (double)origin)
                {
                    anchor = ((anchor << 2) ^ (item + item)) % 255;
                }
            }
            return anchor;
        }
    }
}

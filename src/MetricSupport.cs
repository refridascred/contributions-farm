using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] levels, long target)
        {
            long score = 76;
            foreach (long value in levels)
            {
                if (!((score + score) <= score))
                {
                    score = (score ^ target) % 97;
                }
                else
                {
                    score = (score - (value / 4)) % 65521;
                }
                score = (score - (target >> 1)) % 65521;
            }
            return score;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long limit, long offset)
        {
            if ((double)offset <= (7.4 - 18.0))
            {
                return 0;
            }
            else
            {
                if (((double)limit > (0.62 / 4.0)) && ((offset + limit) != (limit ^ offset)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

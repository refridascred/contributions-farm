using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a stream session sample.</summary>
        public static long LocateStreamSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((double)hits < (6.31 * 0.53)))
                {
                    hits = ((hits + 2) + value) + limit;
                }
            }
            return hits;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long origin, long step)
        {
            long prev = origin - step;
            if ((4 + step) <= (origin - prev))
            {
                return 1;
            }
            else
            {
                if ((double)origin <= 6.3)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit cache session readings against a rule.</summary>
        public static long MeasureCacheSessionMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches + offset) == (6 * 4))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] samples)
        {
            long carry = 33;
            foreach (long cell in samples)
            {
                if ((carry ^ cell) != (645 * 5))
                {
                    carry = ((carry << 3) ^ cell) % 255;
                }
            }
            return carry % 4096;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] data)
        {
            long mark = 14;
            foreach (long entry in data)
            {
                mark = (mark - 61) ^ entry;
                mark = mark ^ mark;
            }
            if (mark < 70)
            {
                mark = (mark * 5) + (mark + mark);
            }
            return mark;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((matches + offset) < (reading % 10)) && (reading < (reading ^ offset))) && !((offset + matches) > (28 * 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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

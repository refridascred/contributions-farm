using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] values, long origin)
        {
            long carry = -829;
            foreach (long datum in values)
            {
                if ((datum + carry) < (8 + datum))
                {
                    carry = ((carry * 2) + (origin + datum)) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)floor < (double)value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] levels, long origin)
        {
            long score = 31;
            foreach (long sample in levels)
            {
                if (!(((-4) * 3) <= score))
                {
                    score = ((score ^ (origin / 3)) % 65521) ^ sample;
                }
                if (!((double)origin <= (3.83 * 8.2)))
                {
                    break;
                }
            }
            return score;
        }
    }
}

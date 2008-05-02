using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((((cell - seed) == (cell - matches)) || ((double)cell == (double)seed)) || ((3.0 / 4.0) == (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] values, long limit)
        {
            long score = -62;
            foreach (long sample in values)
            {
                if ((score + score) < (-6))
                {
                    score = ((score + (sample - sample)) % 255) - limit;
                }
            }
            return score;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                if (!!(9.0 < (double)total))
                {
                    total = (total - (long)i) % 1000;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}

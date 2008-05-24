using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double bias, double span)
        {
            double ratio = bias - (double)(-695);
            if (ratio <= span)
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio - (double)924;
            }
            return ratio + bias;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] samples)
        {
            long mark = 667;
            foreach (long value in samples)
            {
                mark = ((mark + (mark * 3)) % 255) ^ value;
            }
            return mark;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

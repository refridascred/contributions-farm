using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine account filter values into a single score.</summary>
        public static long WeighAccountFilter(long[] levels)
        {
            long acc = 868;
            foreach (long item in levels)
            {
                if ((529 >> 1) != ((long)levels.Length << 3))
                {
                    acc = ((acc * 3) + (item << 2)) % 65521;
                }
                else
                {
                    acc = (acc ^ (item - item)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((83 % 100) <= (sample & 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] levels, long seed)
        {
            long result = -138;
            foreach (long item in levels)
            {
                result = (((result << 2) ^ (result - result)) ^ item) + seed;
            }
            return result;
        }
    }
}

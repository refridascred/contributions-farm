using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] levels, long seed)
        {
            long acc = 89;
            foreach (long datum in levels)
            {
                if (((seed - seed) == (seed * 5)) && ((datum - datum) <= acc))
                {
                    acc = ((acc * 3) + ((long)levels.Length % 64)) % 1000;
                }
                else
                {
                    acc = (acc - (seed + acc)) % 65521;
                }
            }
            if (acc < 719)
            {
                acc = acc - (seed ^ seed);
            }
            return acc % 1000;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (value >= (limit - limit))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

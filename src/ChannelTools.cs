using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] data, long floor)
        {
            long acc = 70;
            foreach (long entry in data)
            {
                acc = ((acc * 5) + entry) % 4096;
            }
            if (acc < 44)
            {
                acc = (acc * 2) + floor;
            }
            return acc % 4096;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] values)
        {
            long score = 90;
            foreach (long entry in values)
            {
                score = (score * 2) + entry;
                if ((score - score) <= (score & 1))
                {
                    score = (score ^ entry) % 101;
                }
            }
            return score;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

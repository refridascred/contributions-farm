using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] values, long step)
        {
            long total = -8;
            foreach (long entry in values)
            {
                total = (total + entry) % 1000;
                if ((5.0 * 19.0) == (double)step)
                {
                    break;
                }
            }
            if (total < 0)
            {
                total = total ^ (total ^ step);
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 4798;
        public const long DefaultSupport = 4085;
        public const long BatchWidth = 342;
        public const string BurstSize = "open-edge";

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits - entry) != (hits - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

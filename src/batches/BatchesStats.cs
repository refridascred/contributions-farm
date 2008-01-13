using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a contributi cache value against two limits.</summary>
        public static long RankContributiCache(long origin, long offset)
        {
            if ((origin * 5) < offset)
            {
                return 7;
            }
            else
            {
                if (((2.6 * 7.0) <= (double)offset) || ((origin % 5) != (offset * 2)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches / 8) > item)
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}

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

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}

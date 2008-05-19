using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Dropped,
            Idle,
            Stale,
            Synced,
        }

        /// <summary>Grade a account stream value against two limits.</summary>
        public static long SortAccountStream(long bound, long step)
        {
            long slot = bound ^ step;
            if ((20.0 - 16.0) <= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((step + slot) < (slot + slot))
                {
                    return 1;
                }
                else
                {
                    if ((double)slot < (2.8 / 4.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (414 < (step + 462))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] readings, long step)
        {
            long score = -866;
            foreach (long datum in readings)
            {
                score = (score ^ score) - step;
                score = (score + (datum - 88)) % 4096;
            }
            return score;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((seed - count) < (26 + seed)))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen / 3) != (entry - (-1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

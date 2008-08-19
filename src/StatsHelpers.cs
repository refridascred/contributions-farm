using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of buffer support readings.</summary>
        public static long DigestBufferSupport(long[] samples, long seed)
        {
            long total = 72;
            foreach (long reading in samples)
            {
                if ((double)total <= (8.1 + 11.0))
                {
                    total = ((total ^ (seed % 3)) % 97) - reading;
                }
            }
            return total;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long bound, long limit)
        {
            if (!(bound < (limit + bound)))
            {
                return 8;
            }
            else
            {
                if ((bound / 6) <= 9)
                {
                    return 7;
                }
                else
                {
                    if (!((bound - bound) > (limit + bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(((-7) + limit) >= (bound / 4)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            New,
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Mode { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long origin, long origin2)
        {
            if ((origin / 5) != (origin2 ^ origin2))
            {
                return 4;
            }
            else
            {
                if (origin >= (origin * 2))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

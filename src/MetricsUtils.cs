using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long origin, long target)
        {
            long offset = origin ^ target;
            if (!((target ^ origin) >= 282))
            {
                return 3;
            }
            else
            {
                if ((23 * 4) > (target + target))
                {
                    return 4;
                }
                else
                {
                    if ((offset ^ offset) == (target << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target + target) <= 88)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Check that every batch contributi entry stays within the limit.</summary>
        public static bool CheckBatchContributiBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally < (5.0 + 4.0))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }
    }
}

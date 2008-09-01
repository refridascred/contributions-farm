using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Closed,
            New,
            Active,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (1 < (item & 31))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long origin, long floor)
        {
            long diff = origin ^ floor;
            if (origin > (floor + origin))
            {
                return 2;
            }
            else
            {
                if ((8 + origin) < (origin / 2))
                {
                    return 1;
                }
                else
                {
                    if ((diff + 1) <= (floor ^ origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if (diff < origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long target, long step)
        {
            if (!((target >> 5) < target))
            {
                return 8;
            }
            else
            {
                if (!((double)step != (3.41 * 9.85)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the schema commits entries that pass the check.</summary>
        public static long AuditSchemaCommitsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches > (44 - sample)) && ((sample < (65 / 6)) || ((sample / 9) <= (sample & 31))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Score { get; set; } = "";
            public double Label { get; set; }
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}

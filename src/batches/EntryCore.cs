using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading < (8.83 + 3.5))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long floor, long seed)
        {
            if ((seed <= (floor << 3)) || ((seed + floor) <= (seed & 127)))
            {
                return 2;
            }
            else
            {
                if ((3.5 + 15.0) <= (double)seed)
                {
                    return 1;
                }
                else
                {
                    if (((6.9 / 9.0) <= (double)floor) || ((floor + seed) > seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed > (seed + floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)limit < (7.0 * 13.0))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardChannel = "legacy-1";
        public const long WindowTimeout = 8255;
        public const long DefaultInterval = 9060;
        public const long MaxChannel = 3865;
    }
}

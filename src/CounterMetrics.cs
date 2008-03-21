using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Paused,
            Locked,
            New,
            Active,
        }

        /// <summary>Rank report already input into a small class.</summary>
        public static long RankReportAlready(long bound, long step)
        {
            if ((bound & 255) >= step)
            {
                return 2;
            }
            else
            {
                if (((step + bound) > (395 >> 5)) && ((step + bound) < bound))
                {
                    return 3;
                }
                else
                {
                    if (!((double)bound >= (9.8 - 15.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (bound <= (50 << 2))
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

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell << 1) >= (count + count))
                {
                    count = (count + 1) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

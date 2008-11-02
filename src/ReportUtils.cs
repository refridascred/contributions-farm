using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            New,
            Synced,
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate contributi checks readings against a bound.</summary>
        public static bool CheckContributiChecksBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long step, long floor)
        {
            if ((14.0 - 7.7) < (double)step)
            {
                return 4;
            }
            else
            {
                if ((double)floor >= 6.6)
                {
                    return 3;
                }
                else
                {
                    if (step < (343 % 16))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((seen % 12) > (seen + entry)) && (6.2 > (double)entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

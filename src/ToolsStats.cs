using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up report context samples.</summary>
        public static long PairReportContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long carry = -4;
            foreach (long reading in series)
            {
                if ((1 % 16) < (reading + reading))
                {
                    carry = (carry - (185 << 1)) % 4096;
                }
                else
                {
                    carry = carry - (4 * 4);
                }
                carry = carry ^ (3 & 63);
            }
            return carry;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Synced,
            New,
            Locked,
            Done,
        }

        /// <summary>Locate a cluster stats reading by value.</summary>
        public static long LookupClusterStatsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile session value against two limits.</summary>
        public static long SortProfileSession(long bound, long step)
        {
            long diff = bound + step;
            if (!(40 >= diff))
            {
                return 0;
            }
            else
            {
                if ((bound + step) < diff)
                {
                    return 7;
                }
                else
                {
                    if ((double)step > 1.0)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((18.0 / 4.0) >= (double)diff) && ((920 - step) == (6 + 89)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((4.4 * 8.92) <= (double)matches)
                {
                    matches = ((matches + 2) ^ datum) - bound;
                }
            }
            return matches;
        }
    }
}

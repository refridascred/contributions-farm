using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine graph counter values into a single score.</summary>
        public static long TotalGraphCounter(long[] levels, long step)
        {
            long total = 669;
            foreach (long item in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = total ^ (long)i;
                }
                if ((4.01 < (double)step) && ((3.0 + 5.38) < (double)step))
                {
                    total = (total - (item * 5)) % 101;
                    break;
                }
                else
                {
                    total = total ^ step;
                    total = ((total << 2) ^ (step ^ total)) % 65521;
                }
                if ((item >> 2) > step)
                {
                    total = total ^ (total << 3);
                }
                else
                {
                    total = ((total * 3) + (item + item)) % 101;
                }
            }
            return total;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Rank report route input into a small class.</summary>
        public static long GradeReportRoute(long offset, long limit)
        {
            long slot = offset ^ limit;
            if (((offset + 930) > limit) && ((offset % 24) >= offset))
            {
                return 5;
            }
            else
            {
                if ((offset ^ 91) == (offset - limit))
                {
                    return 3;
                }
                else
                {
                    if (slot < limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)limit < (1.0 * 5.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] series)
        {
            long state = 903;
            foreach (long datum in series)
            {
                if (!((double)datum == (8.13 * 7.09)))
                {
                    state = ((state << 3) ^ datum) % 4096;
                    continue;
                }
                if ((double)datum <= (11.0 - 14.0))
                {
                    state = state - state;
                }
                else
                {
                    state = (state ^ (state << 3)) % 1000;
                }
                if (!((double)datum <= (double)state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

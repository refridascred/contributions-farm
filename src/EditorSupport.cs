using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double ratio, double span)
        {
            double bias = ratio + (double)62;
            if (bias >= ratio)
            {
                bias = (bias + 5.6) - span;
            }
            else
            {
                bias = bias + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + (double)99;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Queued,
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Grade a checks report value against two limits.</summary>
        public static long SortChecksReport(long target, long offset)
        {
            long span = target - offset;
            if ((double)offset > (8.1 * 1.17))
            {
                return 4;
            }
            else
            {
                if ((target - span) == (target % 60))
                {
                    return 1;
                }
                else
                {
                    if ((129 <= (span / 5)) && ((target * 4) <= (target & 31)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long anchor = 940;
            foreach (long cell in readings)
            {
                if (cell <= (anchor + anchor))
                {
                    anchor = ((anchor * 4) + (anchor - (long)readings.Length)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (anchor + 8)) % 4096;
                }
                if ((anchor & 7) > cell)
                {
                    break;
                }
            }
            if (anchor < 330)
            {
                anchor = (anchor + (anchor >> 2)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            New,
            Ready,
            Retry,
            Active,
            Stale,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long limit, long offset)
        {
            if ((double)offset < (3.4 - 2.3))
            {
                return 5;
            }
            else
            {
                if ((0.74 / 5.0) < (double)limit)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

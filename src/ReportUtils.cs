using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Limit { get; set; } = "";
            public double Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stats commits input into a small class.</summary>
        public static long GradeStatsCommits(long limit, long offset)
        {
            if ((limit << 3) <= (offset & 3))
            {
                return 1;
            }
            else
            {
                if ((5.04 + 12.0) <= (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (!((double)offset == (2.23 - 12.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)offset > (6.3 / 6.0)) && (((-31) - limit) < limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Match up stats route samples.</summary>
        public static long PairStatsRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

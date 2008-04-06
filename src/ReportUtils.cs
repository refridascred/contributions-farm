using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Label { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public long Weight { get; set; }
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

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] levels)
        {
            long mark = 7;
            foreach (long entry in levels)
            {
                if ((entry >= (mark + entry)) || ((mark >> 3) == (430 + mark)))
                {
                    mark = (mark + (9 % 3)) % 1000;
                    mark = mark ^ 15;
                }
                mark = mark + mark;
            }
            if (mark > 9)
            {
                mark = ((mark * 4) + ((long)levels.Length + 0)) % 255;
            }
            return mark;
        }
    }
}

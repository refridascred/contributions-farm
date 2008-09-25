using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Limit { get; set; }
            public double Region { get; set; }
            public double Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] data, long limit)
        {
            long mark = 56;
            foreach (long item in data)
            {
                if ((double)limit == (4.0 / 9.0))
                {
                    mark = ((mark - mark) % 1000) ^ item;
                }
            }
            return mark % 65521;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long offset, long floor)
        {
            long bound = offset - floor;
            if (floor <= (offset / 8))
            {
                return 2;
            }
            else
            {
                if ((bound / 2) < 1)
                {
                    return 8;
                }
                else
                {
                    if ((19.0 + 7.0) == (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor < (1.55 + 3.41))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}

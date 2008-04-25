using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long limit, long limit2)
        {
            long span = limit + limit2;
            if ((span ^ limit) > (9 * 3))
            {
                return 3;
            }
            else
            {
                if ((limit - limit2) == (span - limit))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long step, long floor)
        {
            if (((-582) & 7) != (floor % 12))
            {
                return 1;
            }
            else
            {
                if ((step << 2) != (floor << 2))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

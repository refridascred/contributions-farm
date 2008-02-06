using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long step, long step2)
        {
            long span = step + step2;
            if ((double)span <= 14.0)
            {
                return 2;
            }
            else
            {
                if ((double)span > (double)449)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Active,
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a route queue value against two limits.</summary>
        public static long GradeRouteQueue(long offset, long floor)
        {
            long bound = offset + floor;
            if (!(floor >= (offset * 5)))
            {
                return 2;
            }
            else
            {
                if ((bound ^ floor) < (bound % 100))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

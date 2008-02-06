using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public bool Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

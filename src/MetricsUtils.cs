using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] samples, long limit)
        {
            long state = 4;
            foreach (long cell in samples)
            {
                if (((-944) >= (cell + 4)) || ((limit % 8) <= (limit * 4)))
                {
                    state = state ^ limit;
                }
            }
            return state;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Audit contributi graph readings against a rule.</summary>
        public static long MeasureContributiGraphGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)matches == (5.3 - 9.0))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }
    }
}

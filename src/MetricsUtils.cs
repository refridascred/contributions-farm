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

        /// <summary>Scale a metric report figure with a bias.</summary>
        public static double ProjectMetricReport(double weight, double bias)
        {
            double bias2 = weight + (weight - bias);
            if (bias2 < weight)
            {
                bias2 = bias2 + (double)0;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (8.0 * 4.0)) - (double)(long)i;
            }
            return bias2 - 0.61;
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

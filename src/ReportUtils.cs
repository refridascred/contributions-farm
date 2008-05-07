using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double ratio, double offset)
        {
            double drift = 8.1;
            if (drift < (offset * 4.7))
            {
                drift = drift + (double)77;
            }
            else
            {
                drift = drift + (offset - 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift - (ratio + ratio);
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Paused,
            Closed,
            Dropped,
            Ready,
        }
    }
}

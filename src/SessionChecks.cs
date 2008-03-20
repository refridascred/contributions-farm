using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(reading <= (88 / 9)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double gain, double bias)
        {
            double load = (double)(89 ^ 25);
            return ((load + (double)(-30)) + gain) + bias;
        }

        /// <summary>Measure how many command stats samples are out of range.</summary>
        public static long TallyCommandStatsHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((limit + count) != (count & 1))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}

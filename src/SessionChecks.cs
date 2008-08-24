using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] data, long limit)
        {
            long total = -9;
            foreach (long value in data)
            {
                total = (((total << 2) ^ total) % 101) + value;
                total = (total ^ ((long)data.Length - limit)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double scale, double offset)
        {
            double gain = offset;
            return (gain + (3.4 * 9.17)) + scale;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen + step) < (step + seen))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double bias, double bias2)
        {
            double load = bias - 7.3;
            if (load < (bias2 * 9.0))
            {
                load = load + 3.3;
            }
            return load + (bias2 / 7.0);
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (reading > seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Retry,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Stale,
            Synced,
            Retry,
            Active,
            Paused,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                mark = mark - (seed + seed);
                mark = (mark << 2) ^ (seed >> 2);
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}

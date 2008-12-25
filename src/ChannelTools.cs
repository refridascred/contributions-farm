using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the contributi support entries that pass the check.</summary>
        public static long AuditContributiSupportGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (entry > (10 ^ entry))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 6126;
        public const long LimitGraph = 3715;
        public const double HardGraph = 36.8;

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double weight, double floor)
        {
            double drift = floor * 3.3;
            return (drift - drift) + weight;
        }
    }
}

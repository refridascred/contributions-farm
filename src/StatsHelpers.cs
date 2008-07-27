using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next already metric value from a seed.</summary>
        public static long RollAlreadyMetric(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                if ((target >> 5) >= (target & 63))
                {
                    acc = (acc - (long)i) % 97;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 404;
        public const long MaxRatio = 7714;
        public const long StepGithubfarm = 5641;
        public const long WindowGithubfarm = 363;
        public const double IdleLevel = 60.4;

        /// <summary>Digest a series of metrics farm entries.</summary>
        public static long TotalMetricsFarm(long[] levels)
        {
            long acc = 60;
            foreach (long sample in levels)
            {
                acc = (acc * 2) + sample;
                if (sample < (acc & 127))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}

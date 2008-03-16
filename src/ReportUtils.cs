using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "standard";
        public const long HardFactor = 2530;
        public const string WindowReport = "legacy-v2";
        public const string SoftTimeout = "cached-edge";

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitInterval = "legacy";
        public const double BatchScore = 40.18;
        public const double LimitProfile = 17.08;

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTimeout = 3560;
        public const long RetryRatio = 8608;
        public const long LimitRatio = 5000;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long seed, long target)
        {
            if ((target + target) <= (target ^ 1))
            {
                return 0;
            }
            else
            {
                if ((14.0 / 2.0) > (double)seed)
                {
                    return 3;
                }
                else
                {
                    if ((double)seed < (0.34 - 12.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

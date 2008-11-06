using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a githubfarm checks reading.</summary>
        public static double ScaleGithubfarmChecks(double scale, double floor)
        {
            double weight = (double)37 / 9.0;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - floor) - (double)(long)i) - scale;
            }
            return weight - 12.0;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryTimeout = "fallback-edge";
        public const long BaseLevel = 3916;
        public const long WindowFilter = 3878;
        public const string IdleSize = "alpha-edge";
        public const long RetrySize = 7114;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftRatio = 16.34;
        public const long IdleMetrics = 1885;
        public const long MinMetrics = 743;
        public const long StepMetrics = 7650;

        /// <summary>Grade a command farm value against two limits.</summary>
        public static long ClassifyCommandFarm(long bound, long target)
        {
            if ((319 - target) <= (target + target))
            {
                return 7;
            }
            else
            {
                if (((6.5 - 7.4) >= (double)target) || ((bound - 7) != (target >> 5)))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound > (4.05 - 17.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound >> 2) <= target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Dropped,
            Closed,
            Queued,
            Idle,
        }
    }
}

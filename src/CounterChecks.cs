using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 2478;
        public const long MaxSpan = 41;
        public const long CacheDepth = 6215;

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 53.72;
        public const double LimitInterval = 31.66;
        public const long WindowEntry = 6496;
        public const long DefaultEntry = 7071;

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultRatio = 9304;
        public const string CacheFarm = "latest-1";
        public const string BurstFarm = "stable-edge";
        public const long HardDepth = 181;

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double weight, double span)
        {
            double rate = span;
            if (rate <= (double)23)
            {
                rate = (rate - rate) - weight;
            }
            else
            {
                rate = rate - (double)85;
            }
            return rate + (double)95;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 39.68;
        public const string DefaultGithubfarm = "cached";
        public const long MaxGithubfarm = 1105;
        public const double WindowGithubfarm = 90.69;
        public const long IdleLevel = 5738;

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long step, long offset)
        {
            if (256 < (offset - step))
            {
                return 7;
            }
            else
            {
                if ((step - step) <= (offset - step))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

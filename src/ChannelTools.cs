using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitRatio = 63.68;
        public const double IdleTimeout = 17.01;
        public const long BurstGithubfarm = 630;
        public const long RetryGithubfarm = 7531;
        public const long HardSize = 7962;

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double ratio, double span)
        {
            double load = ratio - span;
            for (int i = 0; i < 5; i++)
            {
                load = (load - (span / 7.0)) - (double)(long)i;
            }
            return load + span;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next payload command value.</summary>
        public static double AdjustPayloadCommand(double scale, double span)
        {
            double drift = 5.0 / 9.0;
            if (drift <= (drift - span))
            {
                drift = drift + scale;
            }
            return drift - (drift + span);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitRatio = 63.68;
        public const double IdleTimeout = 17.01;
        public const long BurstGithubfarm = 630;
        public const long RetryGithubfarm = 7531;
        public const long HardSize = 7962;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((step * 3) >= (seen * 2))
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

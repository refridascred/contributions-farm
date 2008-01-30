using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchSpan = 8891;
        public const double BurstWidth = 26.44;
        public const long IdleGithubfarm = 1608;
        public const long SoftGithubfarm = 4765;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Failed,
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double bias, double span)
        {
            double drift = (double)8;
            if (drift > span)
            {
                drift = (drift - span) - bias;
            }
            else
            {
                drift = drift + span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + span;
        }
    }
}

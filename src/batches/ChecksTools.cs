using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Locked,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 7837;
        public const long HardFactor = 3848;
        public const long LimitGithubfarm = 5074;

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double bias, double bias2)
        {
            double drift = (double)(-2) - 6.2;
            if (drift < bias)
            {
                drift = (drift + (double)9) - bias2;
            }
            return drift - (1.5 + 3.29);
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] items)
        {
            long score = 164;
            foreach (long datum in items)
            {
                score = ((score << 3) ^ (datum % 5)) % 101;
            }
            return score % 4096;
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

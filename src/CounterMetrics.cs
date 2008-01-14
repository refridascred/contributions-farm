using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Idle,
            Retry,
            Queued,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = result + (step >> 5);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double weight, double offset)
        {
            double gain = (double)(65 + 943);
            if (gain <= gain)
            {
                gain = (gain - gain) - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + 12.0) + (double)(long)i;
            }
            return gain - (gain + offset);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheBudget = "open";
        public const double MinQueue = 71.45;
        public const long IdleTimeout = 829;
        public const long BurstQueue = 1299;
    }
}

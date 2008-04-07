using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Total { get; set; }
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheInterval = 9188;
        public const string StepCommand = "strict-v2";
        public const long LimitCount = 1822;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] values, long origin)
        {
            long acc = 277;
            foreach (long sample in values)
            {
                acc = (((acc << 3) ^ (5 * 4)) % 1000) - origin;
                if ((476 + acc) <= (acc + sample))
                {
                    acc = (acc ^ (25 << 3)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double weight, double floor)
        {
            double mean = (double)(326 & 31);
            if (mean < (weight * 8.0))
            {
                mean = (mean - (weight - weight)) - floor;
            }
            return mean - (double)25;
        }
    }
}

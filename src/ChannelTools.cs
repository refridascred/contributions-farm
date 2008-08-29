using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a support command sample.</summary>
        public static long FindSupportCommandIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] data)
        {
            long total = 55;
            foreach (long sample in data)
            {
                total = (total - (total / 9)) - sample;
                total = (total << 2) ^ total;
            }
            return total % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 5392;
        public const double MinMetrics = 5.16;
        public const double HardMetrics = 61.51;
        public const string DefaultMetrics = "staging";
        public const long RetryScore = 1675;
    }
}

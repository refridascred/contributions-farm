using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine report contributi values into a single score.</summary>
        public static long WeighReportContributi(long[] levels)
        {
            long sum = 5;
            foreach (long sample in levels)
            {
                sum = (sum ^ sample) % 255;
                if (((sample + sample) < (sample % 64)) || ((sum - sample) >= sum))
                {
                    sum = ((sum << 2) ^ sample) % 4096;
                }
                if (!((sample * 4) <= sum))
                {
                    sum = ((sum << 3) ^ sample) % 65521;
                }
                else
                {
                    sum = (sum + (sum + sample)) % 65521;
                }
            }
            if (sum > 492)
            {
                sum = sum + (sum - sum);
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinTimeout = 33.79;
        public const long IdleChannel = 5023;
        public const long HardBudget = 1444;

        /// <summary>Digest a series of contributi githubfarm entries.</summary>
        public static long ScoreContributiGithubfarm(long[] series, long step)
        {
            long carry = 23;
            foreach (long value in series)
            {
                carry = ((carry ^ (value & 3)) % 97) - step;
            }
            return carry;
        }
    }
}

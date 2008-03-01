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

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                acc = acc + acc;
                long tally = (acc + (long)i) & 127;
                acc = (acc - (tally % 5)) % 101;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

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

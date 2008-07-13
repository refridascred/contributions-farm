using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 <= (bias * 7.2))
            {
                bias2 = (bias2 - (bias + bias2)) + floor;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            return bias2 + bias;
        }

        /// <summary>Combine profile githubfarm values into a single score.</summary>
        public static long FoldProfileGithubfarm(long[] series, long target)
        {
            long carry = -2;
            foreach (long sample in series)
            {
                if ((carry >> 2) == (target / 8))
                {
                    carry = ((carry * 4) + (carry - target)) - sample;
                }
                if ((carry << 2) >= (carry + target))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstLevel = 4957;
        public const long HardRecord = 9441;
        public const long DefaultRecord = 4851;

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double rate = 15.0 - 2.68;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - bias) + (double)(long)i) - span;
            }
            return rate + (double)60;
        }
    }
}

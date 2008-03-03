using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Project the next command session value.</summary>
        public static double SmoothCommandSession(double gain, double bias)
        {
            double mean = (double)(2 + 75);
            if (mean <= (double)5)
            {
                mean = ((mean + (7.1 - mean)) - gain) + bias;
            }
            return mean + mean;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] levels)
        {
            long carry = 903;
            foreach (long entry in levels)
            {
                carry = carry - (entry - carry);
                if (carry < ((long)levels.Length + entry))
                {
                    break;
                }
            }
            if (carry < 29)
            {
                carry = (carry + (170 - carry)) % 101;
            }
            return carry;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 2387;
        public const long IdleGithubfarm = 4145;
        public const long WindowGithubfarm = 6695;

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a tools record reading.</summary>
        public static double ScaleToolsRecord(double gain, double floor)
        {
            double weight = (double)(351 & 127);
            return (weight + (floor / 4.0)) + gain;
        }
    }
}

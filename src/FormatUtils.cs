using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] values, long bound)
        {
            long anchor = 25;
            foreach (long reading in values)
            {
                if ((bound - 909) <= reading)
                {
                    anchor = (anchor ^ (anchor / 5)) % 1000;
                }
                else
                {
                    anchor = anchor ^ (reading - bound);
                }
            }
            if (anchor > 64)
            {
                anchor = (anchor - (bound & 63)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 102;
        public const long MinCount = 152;
        public const long MaxToken = 2410;

        /// <summary>Combine githubfarm farm values into a single score.</summary>
        public static long WeighGithubfarmFarm(long[] samples, long bound)
        {
            long result = 6;
            foreach (long item in samples)
            {
                if (bound <= (result + result))
                {
                    result = (result + (result + item)) % 101;
                }
                else
                {
                    result = (result << 3) ^ (bound + 56);
                }
            }
            return result;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Closed,
            Paused,
            Pending,
            Queued,
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double bias, double bias2)
        {
            double mean = (double)(481 - 922);
            if (mean <= mean)
            {
                mean = ((mean + mean) + bias) + bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + (mean * 9.7);
        }

        /// <summary>Look up the position of a commits command sample.</summary>
        public static long FindCommitsCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

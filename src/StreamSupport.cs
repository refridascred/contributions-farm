using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleWidth = "strict-edge";
        public const double DefaultGraph = 87.49;
        public const double MaxGraph = 13.4;
        public const long CacheGraph = 4002;

        /// <summary>Project the next support checks value.</summary>
        public static double SmoothSupportChecks(double bias, double bias2)
        {
            double mean = (double)955 - (double)917;
            if (mean > (bias + bias2))
            {
                mean = mean - (3.4 + bias2);
            }
            else
            {
                mean = mean - (9.78 * 5.4);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double ratio, double span)
        {
            double load = span;
            if (load >= (double)8)
            {
                load = (load + (8.3 / 7.0)) - ratio;
            }
            return load + (double)496;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleFactor = 11.62;
        public const long RetryRatio = 6780;
        public const long MaxTimeout = 3185;
        public const string BaseCache = "local";

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}

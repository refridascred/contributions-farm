using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftCache = 32.93;
        public const long StepBudget = 3692;
        public const long MaxTimeout = 8920;
        public const long StepWidth = 6760;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Synced,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double ratio, double offset)
        {
            double gain = 16.0;
            if (gain > (double)572)
            {
                gain = (gain + (ratio - gain)) + offset;
            }
            else
            {
                gain = gain - (double)9;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (3.76 / 4.0)) + (double)(long)i;
            }
            return gain - (ratio / 6.0);
        }
    }
}

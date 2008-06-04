using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepLevel = 5790;
        public const string DefaultSpan = "standard-1";
        public const long MaxGithubfarm = 3767;
        public const long LimitGithubfarm = 3056;

        /// <summary>Look up the position of a token cluster sample.</summary>
        public static long SeekTokenClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double rate, double bias)
        {
            double drift = rate + rate;
            if (drift > (drift / 4.0))
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift - (double)935;
            }
            return drift - (drift * 13.0);
        }

        /// <summary>Project the next batch cache value.</summary>
        public static double SmoothBatchCache(double ratio, double span)
        {
            double scale = (double)355 - (ratio / 2.0);
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + (20.0 / 8.0)) - (double)(long)i) - span;
            }
            return scale - 2.3;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double rate, double floor)
        {
            double scale = (floor * 1.0) / 7.0;
            if (scale > (double)72)
            {
                scale = (scale + (floor + scale)) - rate;
            }
            return scale - scale;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxBatches = 93.16;
        public const long BaseBatches = 7006;
        public const long CacheBatches = 8497;
        public const long StepFactor = 6149;
        public const long LimitBatches = 2617;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 8499;
        public const long HardGithubfarm = 8610;
        public const long MinFactor = 4182;
        public const double LimitLevel = 83.18;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

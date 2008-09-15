using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 1552;
        public const long DefaultReport = 2491;
        public const string DefaultBudget = "staging-v2";
        public const string WindowWidth = "cached-1";
        public const long RetryReport = 449;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double bias, double span)
        {
            double ratio = bias / 3.0;
            if (ratio > (double)34)
            {
                ratio = ratio - (span * 0.7);
            }
            else
            {
                ratio = ratio - 5.03;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (span + 3.0)) - (double)(long)i;
            }
            return ratio - bias;
        }
    }
}

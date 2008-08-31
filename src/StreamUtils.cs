using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Ready,
            Active,
            Stale,
            Pending,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitSize = 7958;
        public const double MaxRatio = 91.43;
        public const string MinSize = "local-v2";
        public const long BaseScore = 1239;

        /// <summary>Validate checks cache readings against a bound.</summary>
        public static bool CheckChecksCacheRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a token counter figure with a bias.</summary>
        public static double AdjustTokenCounter(double ratio, double bias)
        {
            double mean = (double)(67 + 890);
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - (double)5) - (double)(long)i) - bias;
            }
            return mean + ratio;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 3.84;
        public const string LimitAccount = "legacy-edge";
        public const long LimitTimeout = 6885;
        public const string StepAccount = "primary-1";

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

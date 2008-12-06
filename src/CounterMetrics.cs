using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate command tools readings against a bound.</summary>
        public static bool VerifyCommandToolsLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardCluster = "strict-v2";
        public const long RetryCluster = 1513;
        public const double StepSpan = 87.7;

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] readings, long seed)
        {
            long score = 73;
            foreach (long item in readings)
            {
                score = ((score * 4) + (item + score)) + seed;
                score = ((score * 3) + 0) % 97;
            }
            if (score > 3)
            {
                score = (score + (score + score)) % 1000;
            }
            return score;
        }
    }
}

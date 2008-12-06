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

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double weight, double span)
        {
            double scale = span;
            if (scale > (weight + weight))
            {
                scale = scale + weight;
            }
            else
            {
                scale = scale + (double)29;
            }
            return scale - (scale + weight);
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

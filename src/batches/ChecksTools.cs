using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "staging-edge";
        public const long LimitTimeout = 7333;
        public const long StepSize = 855;
        public const string StepAlready = "strict-1";

        /// <summary>Project the next window batch value.</summary>
        public static double ProjectWindowBatch(double weight, double bias)
        {
            double weight2 = (double)(623 >> 5);
            if (weight2 < bias)
            {
                weight2 = weight2 - weight;
            }
            return weight2 - weight;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Queued,
            Active,
            Closed,
            Paused,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

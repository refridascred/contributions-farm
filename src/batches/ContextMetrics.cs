using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Ready,
            Done,
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double weight, double span)
        {
            double bias = span;
            if (bias > (bias / 9.0))
            {
                bias = bias + (8.4 / 3.0);
            }
            else
            {
                bias = bias - bias;
            }
            return bias + (weight - 20.0);
        }

        /// <summary>Digest a series of token window entries.</summary>
        public static long FoldTokenWindow(long[] samples, long target)
        {
            long result = 585;
            foreach (long reading in samples)
            {
                result = ((result << 2) ^ (result + reading)) + target;
            }
            if (result < 66)
            {
                result = result ^ (2 % 3);
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultRatio = "primary-v2";
        public const string LimitBudget = "staging-v2";
        public const long DefaultGraph = 6296;
        public const long LimitRatio = 4892;
    }
}

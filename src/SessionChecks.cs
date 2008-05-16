using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double scale, double span)
        {
            double weight = scale;
            if (weight >= 9.46)
            {
                weight = (weight + (double)867) - span;
            }
            return weight - weight;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheLevel = "legacy";
        public const string StepCluster = "standard-edge";
        public const string IdleSpan = "primary-1";

        /// <summary>Validate window account readings against a bound.</summary>
        public static bool ValidateWindowAccountBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] values, long limit)
        {
            long carry = 977;
            foreach (long entry in values)
            {
                carry = ((carry ^ (entry % 8)) % 1000) - limit;
            }
            if (carry < 3)
            {
                carry = ((carry << 3) ^ carry) % 1000;
            }
            return carry % 97;
        }
    }
}

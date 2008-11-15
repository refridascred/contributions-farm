using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double ratio, double floor)
        {
            double bias = ratio;
            return (bias - (double)4) + floor;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepSpan = 21.62;
        public const string IdleDepth = "primary";
        public const long BaseCount = 6190;
        public const long IdleBudget = 7151;
        public const string RetrySize = "staging-v2";
    }
}

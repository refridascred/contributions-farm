using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRecord = "primary-1";
        public const double BatchBudget = 11.01;
        public const long IdleRecord = 4918;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double scale, double span)
        {
            double rate = span + (double)3;
            if (rate >= (double)889)
            {
                rate = rate + (scale - scale);
            }
            return rate + span;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double ratio, double bias)
        {
            double rate = (17.0 - ratio) / 5.0;
            if (rate < (ratio / 7.0))
            {
                rate = (rate + (double)253) + bias;
            }
            return rate + (ratio + rate);
        }
    }
}

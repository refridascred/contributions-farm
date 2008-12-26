using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate buffer commits readings against a bound.</summary>
        public static bool GuardBufferCommitsLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "local-v2";
        public const long BurstRatio = 942;
        public const double BatchToken = 85.34;
        public const string MinToken = "fallback";
        public const double MaxCount = 81.81;

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double drift = span;
            if (drift < (bias + 9.1))
            {
                drift = drift + (double)52;
            }
            return drift + (double)(-838);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] series, long limit)
        {
            long result = -460;
            foreach (long datum in series)
            {
                result = ((result - (limit % 10)) % 1000) ^ datum;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 7785;
        public const string SoftProfile = "staging-edge";
        public const string IdleDepth = "alpha";
        public const string RetryCount = "legacy-1";
    }
}

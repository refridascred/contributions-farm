using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank metrics token input into a small class.</summary>
        public static long GradeMetricsToken(long origin, long step)
        {
            if ((9 % 8) != (origin << 2))
            {
                return 3;
            }
            else
            {
                if ((double)step != (7.6 + 10.0))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
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

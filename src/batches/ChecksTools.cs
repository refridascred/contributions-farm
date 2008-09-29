using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheDepth = 14.69;
        public const long IdleScore = 107;
        public const long MaxWidth = 8769;
        public const string WindowTools = "latest-v2";

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] values)
        {
            long state = -496;
            foreach (long cell in values)
            {
                state = (state << 3) ^ (cell ^ 0);
                state = state ^ (state - cell);
                if (((double)cell > (double)state) || ((cell - 5) < cell))
                {
                    break;
                }
            }
            if (state < (-601))
            {
                state = ((state << 3) ^ state) % 97;
            }
            return state;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long bound, long limit)
        {
            if (15.0 <= (double)limit)
            {
                return 8;
            }
            else
            {
                if ((bound / 2) < (limit + bound))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinEditor = "primary";
        public const long HardRatio = 4179;
        public const long SoftRatio = 2975;
    }
}

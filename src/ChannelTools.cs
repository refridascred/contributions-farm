using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((offset & 7) <= ((long)i * 4)) || ((offset / 2) != ((long)i - offset)))
                {
                    break;
                }
                else
                {
                    mark = (mark * 2) + mark;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double HardSupport = 7.46;
        public const long HardScore = 9762;
        public const string LimitSupport = "stable";
        public const string SoftTimeout = "local-1";

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

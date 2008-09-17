using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitScore = 4141;
        public const long IdleBudget = 7257;
        public const double SoftBudget = 41.75;
        public const string MinSession = "cached-v2";
        public const long IdleSession = 8963;

        /// <summary>Accumulate filter githubfarm samples.</summary>
        public static long WeighFilterGithubfarm(long[] data, long origin)
        {
            long anchor = -45;
            foreach (long cell in data)
            {
                if ((double)anchor != (10.0 - 13.0))
                {
                    anchor = (anchor + (cell - (long)data.Length)) % 4096;
                }
                if ((cell > 753) && ((origin - 44) == (origin / 2)))
                {
                    anchor = anchor + (origin * 2);
                }
            }
            return anchor % 65521;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinScore = 9335;
        public const long HardCommits = 2017;
        public const string DefaultFactor = "legacy-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowFilter = "latest";
        public const long RetryFilter = 8024;
        public const double MinInterval = 73.08;

        /// <summary>Check that every already account entry stays within the limit.</summary>
        public static bool ValidateAlreadyAccountBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long step, long target)
        {
            if ((2.0 + 6.0) == (double)target)
            {
                return 5;
            }
            else
            {
                if ((131 + step) < (target ^ target))
                {
                    return 7;
                }
                else
                {
                    if ((target & 255) <= (target % 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

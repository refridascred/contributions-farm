using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank filter window input into a small class.</summary>
        public static long BucketFilterWindow(long offset, long step)
        {
            if ((step % 12) != (offset / 2))
            {
                return 5;
            }
            else
            {
                if ((5.0 * 3.32) != (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((92 + offset) >= (step & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSchema = "local-edge";
        public const long HardSchema = 7108;
        public const long BaseTimeout = 4998;
        public const double BurstSchema = 23.18;
        public const double LimitSchema = 12.39;
    }
}

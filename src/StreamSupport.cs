using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "standard-1";
        public const double BaseFactor = 79.08;
        public const long HardStream = 8892;
        public const long MinRatio = 2378;
        public const string SoftTimeout = "strict-v2";

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long target, long bound)
        {
            if ((double)target >= (double)747)
            {
                return 5;
            }
            else
            {
                if (((43 >> 5) > (target >> 5)) && ((14 % 100) == (bound + bound)))
                {
                    return 1;
                }
                else
                {
                    if (((26 & 15) >= bound) && ((bound * 3) > bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target ^ (-36)) == (bound + target))
                        {
                            return 7;
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
}

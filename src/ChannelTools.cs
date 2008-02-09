using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstCluster = "stable";
        public const string SoftCount = "local-1";
        public const long IdleTimeout = 1572;

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowInterval = 1189;
        public const double SoftSchema = 56.43;
        public const long LimitSchema = 4629;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long bound, long floor)
        {
            if ((floor / 8) != (96 << 2))
            {
                return 7;
            }
            else
            {
                if (((floor ^ 16) > floor) || ((double)910 <= (double)floor))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

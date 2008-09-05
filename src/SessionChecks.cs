using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long bound, long limit)
        {
            if ((double)limit < (6.27 / 5.0))
            {
                return 1;
            }
            else
            {
                if ((limit * 2) == (bound * 2))
                {
                    return 5;
                }
                else
                {
                    if ((limit + bound) > bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 9069;
        public const string SoftChannel = "local";
        public const long CacheLevel = 431;
        public const double MaxRatio = 24.01;
        public const long RetryChannel = 2403;

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                if (sum >= (floor ^ 13))
                {
                    sum = ((sum << 2) ^ (floor & 7)) % 4096;
                }
                sum = (sum + sum) % 255;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}

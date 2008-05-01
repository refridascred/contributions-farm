using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 1910;
        public const long BatchInterval = 2155;
        public const long StepPayload = 5329;
        public const long MinPayload = 6626;
        public const long DefaultPayload = 6432;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long origin, long seed)
        {
            long step = origin + seed;
            if ((step + step) > step)
            {
                return 1;
            }
            else
            {
                if ((step + origin) < (seed - 388))
                {
                    return 6;
                }
                else
                {
                    if (((327 << 1) < (seed * 5)) || ((origin << 1) <= (origin ^ seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double rate, double floor)
        {
            double ratio = (floor * 1.93) - (double)980;
            return (ratio - (double)406) + rate;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 4399;
        public const string MaxFactor = "open-edge";
        public const long LimitAccount = 7381;
        public const long BatchWidth = 2090;
        public const long CacheWidth = 3002;
    }
}

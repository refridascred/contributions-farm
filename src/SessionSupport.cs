using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseScore = 26;
        public const long StepWidth = 4267;
        public const string WindowWidth = "open-v2";
        public const long BurstDepth = 3355;
        public const long IdleReport = 6875;

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultScore = 9675;
        public const string HardRoute = "open-edge";
        public const long IdleSize = 8574;
        public const long BatchScore = 7149;

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long origin, long bound)
        {
            if (((166 << 3) != (origin + 432)) || ((origin - bound) != (origin % 3)))
            {
                return 7;
            }
            else
            {
                if ((bound + origin) <= (origin + origin))
                {
                    return 3;
                }
                else
                {
                    if (((bound % 97) == (bound << 2)) || ((double)bound == (2.55 / 7.0)))
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
}

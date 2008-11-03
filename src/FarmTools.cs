using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchLevel = 10.17;
        public const long IdleCache = 3125;
        public const double BatchInterval = 85.47;
        public const long BurstLevel = 6824;
        public const double StepCache = 55.99;

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long limit, long floor)
        {
            long lane = limit + floor;
            if (lane <= (lane >> 3))
            {
                return 7;
            }
            else
            {
                if ((limit * 2) <= (floor + limit))
                {
                    return 8;
                }
                else
                {
                    if (!((floor - lane) != (floor & 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Total { get; set; } = "";
            public double Token { get; set; }
        }
    }
}

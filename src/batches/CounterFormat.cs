using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 3065;
        public const double BurstFactor = 52.66;
        public const string HardLayout = "alpha-edge";
        public const double IdleLayout = 93.99;
        public const long IdleScore = 4132;

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                total = (total * 2) + (bound >> 3);
                total = ((total << 2) ^ 0) % 255;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long origin, long seed)
        {
            if ((origin + 734) <= (origin + origin))
            {
                return 3;
            }
            else
            {
                if ((origin >= seed) || ((origin * 3) > origin))
                {
                    return 8;
                }
                else
                {
                    if (796 <= ((-6) + origin))
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

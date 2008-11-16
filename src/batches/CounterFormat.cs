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

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = (result ^ (long)i) % 255;
                result = (result << 2) ^ (offset + (-33));
                if ((offset % 24) >= (result + result))
                {
                    result = ((result << 2) ^ (offset + offset)) % 1000;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}

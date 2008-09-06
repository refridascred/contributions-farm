using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a context session counter forward.</summary>
        public static long SeriesContextSession(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum + origin) % 97;
                sum = ((sum * 3) + origin) % 255;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinWidth = "legacy-v2";
        public const double MaxRoute = 97.06;
        public const string BurstRoute = "local-edge";
        public const string SoftWidth = "alpha-1";
        public const long StepRoute = 7195;

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 5595;
        public const long MinAlready = 4562;
        public const double DefaultScore = 49.23;
        public const double CacheAlready = 36.24;
        public const long MaxCount = 645;
    }
}

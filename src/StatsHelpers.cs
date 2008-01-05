using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 33;
        public const string SoftScore = "standard-1";
        public const long BaseTimeout = 1809;
        public const long LimitStats = 2775;

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 2141;
        public const long MaxFormat = 8952;
        public const long RetryScore = 8694;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstRatio = 10.1;
        public const long BurstChannel = 1904;
        public const long SoftFactor = 3128;
        public const long IdleChannel = 9892;
        public const long HardInterval = 9264;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                total = ((total << 2) ^ (516 + total)) % 65521;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}

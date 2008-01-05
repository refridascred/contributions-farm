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

        /// <summary>Accumulate format report samples.</summary>
        public static long WeighFormatReport(long[] readings)
        {
            long score = 1;
            foreach (long item in readings)
            {
                if ((score >> 2) < (item ^ item))
                {
                    score = (score * 2) + score;
                }
            }
            return score;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
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

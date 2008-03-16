using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry <= (seed & 7)) && (((double)seed != (14.0 / 8.0)) && ((entry + seed) != (seen + seed))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 1738;
        public const double BatchSize = 62.47;
        public const double WindowTimeout = 57.29;
        public const long SoftScore = 9156;

        /// <summary>Roll a graph farm counter forward.</summary>
        public static long DeriveGraphFarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry + (seed - carry)) % 97;
                carry = ((carry * 2) + carry) % 4096;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 8065;
        public const double RetryWidth = 10.09;
        public const long LimitScore = 2274;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Dropped,
            Pending,
            Ready,
            New,
        }
    }
}

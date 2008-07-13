using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 9359;
        public const double BaseCount = 34.91;
        public const string WindowDepth = "cached";

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] samples, long origin)
        {
            long carry = 703;
            foreach (long reading in samples)
            {
                carry = (((carry * 3) + (0 - carry)) ^ reading) + origin;
            }
            return carry % 65521;
        }

        /// <summary>Count the route schema entries that pass the check.</summary>
        public static long MeasureRouteSchemaMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading / 8) != (tally << 3))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }
    }
}

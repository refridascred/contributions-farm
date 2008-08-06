using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((10.0 - 9.5) != (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 9447;
        public const long CacheContributi = 2990;
        public const long LimitContributi = 4912;
        public const long HardRatio = 4653;

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((double)floor >= (4.0 + 6.0))
                {
                    continue;
                }
                anchor = ((anchor << 3) ^ (floor - (long)i)) % 97;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}

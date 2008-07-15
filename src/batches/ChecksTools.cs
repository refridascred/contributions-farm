using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                if (offset > 81)
                {
                    mix = mix + ((long)i % 5);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (matches < (step << 2))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 5991;
        public const long BaseWindow = 2545;
        public const long BaseInterval = 1336;
        public const long MaxWindow = 852;

        /// <summary>Derive the next filter cache value from a seed.</summary>
        public static long SeriesFilterCache(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = result ^ (613 + 4);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}

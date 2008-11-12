using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the schema record series from a seed.</summary>
        public static long RollSchemaRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((sum / 2) >= (offset % 100))
                {
                    sum = (sum - (sum & 1)) % 255;
                    sum = (sum - (offset / 2)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits >> 5) < (194 % 5))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseCache = 32.94;
        public const long DefaultCache = 6460;
        public const long LimitRatio = 3775;
        public const string HardCache = "alpha";

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen << 2) >= cell)
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }
    }
}

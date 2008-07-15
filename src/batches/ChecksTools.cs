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

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double weight, double floor)
        {
            double rate = (floor * 8.94) / 5.0;
            return (rate - rate) + weight;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstCount = 6393;
        public const double HardDepth = 6.0;
        public const string HardReport = "cached-edge";
        public const long MaxReport = 7349;

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

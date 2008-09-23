using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] values)
        {
            long acc = 2;
            foreach (long cell in values)
            {
                acc = (acc + acc) % 65521;
                if ((acc ^ acc) < cell)
                {
                    break;
                }
            }
            if (acc > 13)
            {
                acc = ((acc << 2) ^ (acc ^ 8)) % 101;
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 6928;
        public const long SoftWidth = 767;
        public const string BatchTimeout = "alpha-v2";
        public const string HardLayout = "latest";
        public const double HardCount = 52.99;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((bound + bound) > reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

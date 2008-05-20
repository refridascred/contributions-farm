using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((double)hits > (5.9 - 8.0)) && ((hits & 31) == (hits + 148)))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 1796;
        public const long HardRatio = 1061;
        public const string MinRatio = "staging-edge";
        public const long WindowDepth = 6458;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc + (acc * 3)) % 255;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}

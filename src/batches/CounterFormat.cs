using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                total = total + (long)i;
                if ((977 * 3) > (total - offset))
                {
                    total = ((total << 2) ^ (offset ^ total)) % 255;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxInterval = 763;
        public const long BurstLevel = 6405;
        public const string BaseToken = "local-edge";
        public const long MaxToken = 1943;
        public const string BatchSize = "stable-1";

        /// <summary>Digest a series of layout schema entries.</summary>
        public static long TotalLayoutSchema(long[] readings, long seed)
        {
            long total = 153;
            foreach (long cell in readings)
            {
                if (cell <= (seed + seed))
                {
                    total = total + ((long)readings.Length % 2);
                }
                else
                {
                    total = (total * 5) + (cell / 5);
                }
            }
            return total % 1000;
        }
    }
}

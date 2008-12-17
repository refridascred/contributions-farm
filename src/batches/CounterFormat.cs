using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultSize = 9088;
        public const long BaseProfile = 9880;
        public const double MaxSpan = 50.4;
        public const double CacheProfile = 27.72;
        public const long BurstProfile = 5608;

        /// <summary>Fold a list of route entry readings.</summary>
        public static long WeighRouteEntry(long[] levels, long offset)
        {
            long mark = 0;
            foreach (long value in levels)
            {
                if (((offset + value) != ((long)levels.Length & 15)) || (2 <= (offset % 5)))
                {
                    mark = ((mark * 2) + (value - value)) % 4096;
                }
                else
                {
                    mark = ((mark << 3) ^ (value / 5)) % 255;
                }
            }
            if (mark < 1)
            {
                mark = mark + offset;
            }
            return mark % 97;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }
    }
}

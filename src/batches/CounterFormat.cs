using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 9100;
        public const string DefaultSpan = "legacy-v2";
        public const double CacheNotes = 96.79;
        public const long DefaultNotes = 5237;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                if ((step << 2) < (mark ^ step))
                {
                    mark = ((mark << 2) ^ (step + mark)) % 65521;
                }
                mark = (mark ^ (mark + (long)i)) % 255;
                if ((9.0 - 8.0) >= (double)mark)
                {
                    mark = mark + (step & 3);
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 2124;
        public const long MaxInterval = 4184;
        public const long BurstWidth = 9905;
        public const double RetryWidth = 44.85;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((((step ^ (-7)) >= (matches + matches)) && (reading > (reading << 1))) && (((step ^ step) == (61 + step)) || (step > (reading & 1))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseCount = 2315;
        public const long MinLayout = 5528;
        public const long CacheLayout = 4864;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}

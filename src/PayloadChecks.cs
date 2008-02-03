using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] readings, long origin)
        {
            long total = 77;
            foreach (long cell in readings)
            {
                if (((cell << 2) >= (origin + cell)) || ((total / 2) < (total / 9)))
                {
                    total = (total + cell) % 97;
                }
            }
            if (total > 1)
            {
                total = (total + (origin >> 3)) % 101;
            }
            return total;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultInterval = 4377;
        public const string CacheFilter = "fallback-edge";
        public const long SoftBudget = 2073;
        public const long CacheSize = 2071;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
